﻿using System;
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
        public DataTable DataTable { get; set; } = new DataTable();

        public Form1()
        {
            InitializeComponent();
            FeaturesGridView.DataSource = DataTable;
        }

        private async void SelectExcelButton_Click(object sender, EventArgs e)
        {
            using (var excelDialog = new OpenFileDialog())
            {
                if (excelDialog.ShowDialog() == DialogResult.OK)
                {
                    DataTable = await Task.Run(() => ExcelReader.ImportExceltoDatatable(excelDialog.FileName));
                    FeaturesGridView.DataSource = DataTable;


                    var form2 = new Form2(DataTable);
                    form2.ShowDialog();
                }
            }
        }
    }
}
