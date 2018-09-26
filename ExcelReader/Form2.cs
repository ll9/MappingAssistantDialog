using ExcelReader.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelReader
{
    public partial class Form2 : Form
    {
        BindingList<ExcelSqlMap> MapList { get; set; } = new BindingList<ExcelSqlMap>();
        public DataTable OriginalTable { get; set; }

        public Form2(DataTable originalTable)
        {
            InitializeComponent();
            OriginalTable = originalTable;

            foreach (DataColumn column in OriginalTable.Columns)
            {
                var type = TypeGuesser.GuessType(OriginalTable, column.ColumnName);

                MapList.Add(new ExcelSqlMap(column.ColumnName, type));
            }

            MapGridView.DataSource = MapList;
        }
    }
}
