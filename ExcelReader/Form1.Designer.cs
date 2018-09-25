namespace ExcelReader
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectExcelButton = new System.Windows.Forms.Button();
            this.FeaturesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FeaturesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectExcelButton
            // 
            this.SelectExcelButton.Location = new System.Drawing.Point(570, 353);
            this.SelectExcelButton.Name = "SelectExcelButton";
            this.SelectExcelButton.Size = new System.Drawing.Size(188, 42);
            this.SelectExcelButton.TabIndex = 0;
            this.SelectExcelButton.Text = "Select Excel";
            this.SelectExcelButton.UseVisualStyleBackColor = true;
            this.SelectExcelButton.Click += new System.EventHandler(this.SelectExcelButton_Click);
            // 
            // FeaturesGridView
            // 
            this.FeaturesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeaturesGridView.Location = new System.Drawing.Point(13, 13);
            this.FeaturesGridView.Name = "FeaturesGridView";
            this.FeaturesGridView.Size = new System.Drawing.Size(745, 264);
            this.FeaturesGridView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FeaturesGridView);
            this.Controls.Add(this.SelectExcelButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FeaturesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectExcelButton;
        private System.Windows.Forms.DataGridView FeaturesGridView;
    }
}

