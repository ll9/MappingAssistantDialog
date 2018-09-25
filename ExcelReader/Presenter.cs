using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelReader
{
    class Presenter
    {
        public Form1 View { get; set; }

        public Presenter(Form1 view)
        {
            View = view;
        }

        public void FillDataTableFromExcel(string path)
        {
            var table = ExcelReader.ImportExceltoDatatable(path);
            View.DataTable.Merge(table);
        }
    }
}
