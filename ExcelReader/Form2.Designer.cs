namespace ExcelReader
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KeepListBox = new System.Windows.Forms.ListBox();
            this.RemoveListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.KeepButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeepListBox
            // 
            this.KeepListBox.FormattingEnabled = true;
            this.KeepListBox.Location = new System.Drawing.Point(12, 83);
            this.KeepListBox.Name = "KeepListBox";
            this.KeepListBox.Size = new System.Drawing.Size(267, 238);
            this.KeepListBox.TabIndex = 0;
            // 
            // RemoveListBox
            // 
            this.RemoveListBox.FormattingEnabled = true;
            this.RemoveListBox.Location = new System.Drawing.Point(426, 83);
            this.RemoveListBox.Name = "RemoveListBox";
            this.RemoveListBox.Size = new System.Drawing.Size(254, 244);
            this.RemoveListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Übernehmen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Verwerfen";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(319, 134);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(81, 29);
            this.RemoveButton.TabIndex = 4;
            this.RemoveButton.Text = "->";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // KeepButton
            // 
            this.KeepButton.Location = new System.Drawing.Point(319, 196);
            this.KeepButton.Name = "KeepButton";
            this.KeepButton.Size = new System.Drawing.Size(79, 27);
            this.KeepButton.TabIndex = 5;
            this.KeepButton.Text = "<-";
            this.KeepButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KeepButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveListBox);
            this.Controls.Add(this.KeepListBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox KeepListBox;
        private System.Windows.Forms.CheckedListBox RemoveListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button KeepButton;
    }
}