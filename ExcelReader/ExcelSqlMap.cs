using ExcelReader.Models;
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
        private string _destination;
        public string Destination
        {
            get { return _destination; }
            set { _destination = Regex.Replace(value, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled); }
        }
        public bool Keep { get; set;}
        public DataType DataType { get; set; }



        public ExcelSqlMap(string source, DataType dataType)
        {
            Source = source;
            Destination = source;
            Keep = true;
            DataType = dataType;
        }

    }
}
