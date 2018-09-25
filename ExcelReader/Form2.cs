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

        public Form2(IEnumerable<string> headerNames)
        {
            InitializeComponent();

            foreach (var headerName in headerNames)
            {
                MapList.Add(new ExcelSqlMap(headerName));
            }

            MapGridView.DataSource = MapList;
        }
    }
}
