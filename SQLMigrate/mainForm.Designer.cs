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
            this.btnPreStep = new System.Windows.Forms.Button();
            this.panelStep1 = new System.Windows.Forms.Panel();
            this.panelStep2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSvrType = new System.Windows.Forms.ComboBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAuthType = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.btnNexStep = new System.Windows.Forms.Button();
            this.panelStep1.SuspendLayout();
            this.panelStep2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableCheckedListBox
            // 
            this.tableCheckedListBox.FormattingEnabled = true;
            this.tableCheckedListBox.Location = new System.Drawing.Point(5, 42);
            this.tableCheckedListBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableCheckedListBox.Name = "tableCheckedListBox";
            this.tableCheckedListBox.Size = new System.Drawing.Size(425, 412);
            this.tableCheckedListBox.TabIndex = 0;
            // 
            // dbList
            // 
            this.dbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dbList.FormattingEnabled = true;
            this.dbList.Location = new System.Drawing.Point(5, 6);
            this.dbList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dbList.Name = "dbList";
            this.dbList.Size = new System.Drawing.Size(425, 24);
            this.dbList.TabIndex = 1;
            // 
            // btnPreStep
            // 
            this.btnPreStep.Location = new System.Drawing.Point(238, 475);
            this.btnPreStep.Name = "btnPreStep";
            this.btnPreStep.Size = new System.Drawing.Size(100, 31);
            this.btnPreStep.TabIndex = 2;
            this.btnPreStep.Text = "Previous Step";
            this.btnPreStep.UseVisualStyleBackColor = true;
            this.btnPreStep.Click += new System.EventHandler(this.btnPreStep_Click);
            // 
            // panelStep1
            // 
            this.panelStep1.Controls.Add(this.dbList);
            this.panelStep1.Controls.Add(this.tableCheckedListBox);
            this.panelStep1.Location = new System.Drawing.Point(12, 12);
            this.panelStep1.Name = "panelStep1";
            this.panelStep1.Size = new System.Drawing.Size(435, 455);
            this.panelStep1.TabIndex = 3;
            // 
            // panelStep2
            // 
            this.panelStep2.Controls.Add(this.label6);
            this.panelStep2.Controls.Add(this.textBoxPort);
            this.panelStep2.Controls.Add(this.label5);
            this.panelStep2.Controls.Add(this.comboBoxSvrType);
            this.panelStep2.Controls.Add(this.connectBtn);
            this.panelStep2.Controls.Add(this.label4);
            this.panelStep2.Controls.Add(this.label3);
            this.panelStep2.Controls.Add(this.label2);
            this.panelStep2.Controls.Add(this.label1);
            this.panelStep2.Controls.Add(this.comboBoxAuthType);
            this.panelStep2.Controls.Add(this.textBoxPassword);
            this.panelStep2.Controls.Add(this.textBoxUserID);
            this.panelStep2.Controls.Add(this.textBoxIP);
            this.panelStep2.Location = new System.Drawing.Point(12, 12);
            this.panelStep2.Name = "panelStep2";
            this.panelStep2.Size = new System.Drawing.Size(435, 455);
            this.panelStep2.TabIndex = 4;
            this.panelStep2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Server Port:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPort.Location = new System.Drawing.Point(182, 187);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(197, 22);
            this.textBoxPort.TabIndex = 21;
            this.textBoxPort.Text = "5432";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Target Server Type:";
            // 
            // comboBoxSvrType
            // 
            this.comboBoxSvrType.FormattingEnabled = true;
            this.comboBoxSvrType.Items.AddRange(new object[] {
            "SQL Server",
            "PostgreSQL"});
            this.comboBoxSvrType.Location = new System.Drawing.Point(182, 42);
            this.comboBoxSvrType.Name = "comboBoxSvrType";
            this.comboBoxSvrType.Size = new System.Drawing.Size(197, 24);
            this.comboBoxSvrType.TabIndex = 19;
            this.comboBoxSvrType.SelectedIndex = 1;
            this.comboBoxSvrType.SelectedIndexChanged += new System.EventHandler(this.comboBoxSvrType_SelectedIndexChanged);
            // 
            // connectBtn
            // 
            this.connectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.Location = new System.Drawing.Point(182, 320);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(157, 31);
            this.connectBtn.TabIndex = 18;
            this.connectBtn.Text = "Test Connection";
            this.connectBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "User Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Authentication:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Server Name( IP ):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxAuthType
            // 
            this.comboBoxAuthType.Enabled = false;
            this.comboBoxAuthType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAuthType.FormattingEnabled = true;
            this.comboBoxAuthType.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.comboBoxAuthType.Location = new System.Drawing.Point(182, 135);
            this.comboBoxAuthType.Name = "comboBoxAuthType";
            this.comboBoxAuthType.Size = new System.Drawing.Size(197, 24);
            this.comboBoxAuthType.TabIndex = 11;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(182, 281);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '.';
            this.textBoxPassword.Size = new System.Drawing.Size(197, 22);
            this.textBoxPassword.TabIndex = 13;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserID.Location = new System.Drawing.Point(182, 235);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(197, 22);
            this.textBoxUserID.TabIndex = 12;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIP.Location = new System.Drawing.Point(182, 88);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(197, 22);
            this.textBoxIP.TabIndex = 10;
            // 
            // btnNexStep
            // 
            this.btnNexStep.Location = new System.Drawing.Point(344, 475);
            this.btnNexStep.Name = "btnNexStep";
            this.btnNexStep.Size = new System.Drawing.Size(103, 31);
            this.btnNexStep.TabIndex = 5;
            this.btnNexStep.Text = "Next Step";
            this.btnNexStep.UseVisualStyleBackColor = true;
            this.btnNexStep.Click += new System.EventHandler(this.btnNexStep_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 518);
            this.Controls.Add(this.btnNexStep);
            this.Controls.Add(this.panelStep2);
            this.Controls.Add(this.panelStep1);
            this.Controls.Add(this.btnPreStep);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Migration Tools";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelStep1.ResumeLayout(false);
            this.panelStep2.ResumeLayout(false);
            this.panelStep2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox tableCheckedListBox;
        private System.Windows.Forms.ComboBox dbList;

        public string connectionString;
        private int currentStep; 
        private System.Windows.Forms.Button btnPreStep;
        private System.Windows.Forms.Panel panelStep1;
        private System.Windows.Forms.Panel panelStep2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSvrType;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBoxAuthType;
        public System.Windows.Forms.TextBox textBoxPassword;
        public System.Windows.Forms.TextBox textBoxUserID;
        public System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button btnNexStep;
    }
}