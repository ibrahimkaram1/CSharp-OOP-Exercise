using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer
{
    internal class TextFileAnalyzer :FileAnalyzer, IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
         string filestring = File.ReadAllText(fileInfo.FullName);
            AnalysisResult result = new AnalysisResult();
           var words= filestring.Split(new char[] { ' ',  '\n', '\r' });
            setResult(result);
            if (words.Length > 0 && words[0] == "")
            {
                result.WordCount = 0;
            }
            else
            {
                result.WordCount = words.Length;
            }
            result.CharacterCount = filestring.Length;


            var lines = filestring.Split(new char[] { '\n' });
            result.LineCount = lines.Length;


            //result = GetResult();
            //result.LineCount = lines.Length;
            //result.WordCount = lines.Sum(line => line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length);
            //result.CharacterCount = lines.Sum(line => line.Length);
            //result.FieldCount = lines.Sum(line => line.Split(',').Length);
            //setResult(result);
        }
    }
}
