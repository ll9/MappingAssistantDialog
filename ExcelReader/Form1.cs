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
    public partial class Form1 : Form
    {
        Presenter Presenter { get; set; }
        public DataTable DataTable { get; set; } = new DataTable();

        public Form1()
        {
            InitializeComponent();
            Presenter = new Presenter(this);
            FeaturesGridView.DataSource = DataTable;
        }

        private void SelectExcelButton_Click(object sender, EventArgs e)
        {
            using (var excelDialog = new OpenFileDialog())
            {
                if (excelDialog.ShowDialog() == DialogResult.OK)
                {
                    Presenter.FillDataTableFromExcel(excelDialog.FileName);

                    var headers = DataTable.Columns.Cast<DataColumn>()
                        .Select(column => column.ColumnName);

                    var form2 = new Form2(headers);
                    form2.ShowDialog();
                }
            }
        }
    }
}
