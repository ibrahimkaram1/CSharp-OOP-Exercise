using System;
using System.IO;

namespace Text_Data_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to file analyzer ");
            Console.WriteLine(" please enterfolder path to analyzer");

            string folderPath = Console.ReadLine();

          DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            if (!directoryInfo.Exists)
            {
                Console.WriteLine("Directory does not exist.");
                return;
            }
            var filenames = directoryInfo.GetFiles();
            IFileAnalysis fileAnalysis = null;

            foreach (FileInfo file in filenames)
            {
                if (file.IsTextFile())
                {
                     fileAnalysis = new TextFileAnalyzer();
                fileAnalysis.AnalyzeFile(file);
                var result = ((FileAnalyzer)fileAnalysis).GetResult();
                 Console.WriteLine($"File: {file.Name}");
                    Console.WriteLine($"Lines: {result.LineCount}, " +
                        $"Words: {result.WordCount}, " +
                        $"Characters: {result.CharacterCount}");
                }
                else if (file.IsCSVFile())
                {
                    fileAnalysis = new CSVFileAnalyzer();
                    fileAnalysis.AnalyzeFile(file);
                    var result = ((CSVFileAnalyzer)fileAnalysis).GetResult();
                   
                    Console.WriteLine($"File: {file.Name}");
                Console.WriteLine( $"Fields: {result.FieldCount}");
                }
                else
                {
                    Console.WriteLine($"File: {file.Name} is not a text or CSV file.");
                }

            }

        }
    }
}
