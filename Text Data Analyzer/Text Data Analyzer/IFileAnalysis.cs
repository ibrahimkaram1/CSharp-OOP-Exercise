using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer
{
    internal interface IFileAnalysis
    {
        void AnalyzeFile(FileInfo fileInfo);
    }
}
