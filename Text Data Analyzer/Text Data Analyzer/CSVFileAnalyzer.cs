using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer
{
    internal class CSVFileAnalyzer : FileAnalyzer ,IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string [] filestring = File.ReadAllLines(fileInfo.FullName);
            var rowelments = filestring[0].Split(',');
            AnalysisResult result = new AnalysisResult();

            result .FieldCount = rowelments.Length;
            setResult(result);
        }

        //internal AnalysisResult GetResult()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
