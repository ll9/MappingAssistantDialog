using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExcelReader
{
    class ExcelSqlMap
    {
        public string Source { get; }
        public string Destination { 
            get { return Destination; }
            set
            {
                Destination = Regex.Replace(value, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
            }
        }
        public bool Keep { get; set;}



        public ExcelSqlMap(string source)
        {
            Source = source;
            Destination = source;
            Keep = true;
        }

    }
}
