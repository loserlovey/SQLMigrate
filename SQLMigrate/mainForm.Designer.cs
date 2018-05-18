namespace SQLMigrate
{
    partial class mainForm
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
            this.tableCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.dbList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tableCheckedListBox
            // 
            this.tableCheckedListBox.FormattingEnabled = true;
            this.tableCheckedListBox.Location = new System.Drawing.Point(33, 51);
            this.tableCheckedListBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableCheckedListBox.Name = "tableCheckedListBox";
            this.tableCheckedListBox.Size = new System.Drawing.Size(583, 395);
            this.tableCheckedListBox.TabIndex = 0;
            // 
            // dbList
            // 
            this.dbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dbList.FormattingEnabled = true;
            this.dbList.Location = new System.Drawing.Point(33, 15);
            this.dbList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dbList.Name = "dbList";
            this.dbList.Size = new System.Drawing.Size(583, 24);
            this.dbList.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 461);
            this.Controls.Add(this.dbList);
            this.Controls.Add(this.tableCheckedListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox tableCheckedListBox;
        private System.Windows.Forms.ComboBox dbList;

        public string connectionString;
    }
}