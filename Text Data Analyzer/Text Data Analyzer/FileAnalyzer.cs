using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer
{
    internal class FileAnalyzer
    {
        private AnalysisResult AnalysisResult;
        public AnalysisResult GetResult()
        {
            return AnalysisResult;
        }
       public void setResult(AnalysisResult result)
        {
            AnalysisResult = result;
        }
       
        
    }
}
