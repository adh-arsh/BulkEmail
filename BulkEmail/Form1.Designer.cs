namespace BulkEmail
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.excelGV = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.var1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.uploadExcelBtn = new System.Windows.Forms.Button();
            this.uploadTemplateBtn = new System.Windows.Forms.Button();
            this.fromEmailTB = new System.Windows.Forms.TextBox();
            this.subjectTB = new System.Windows.Forms.TextBox();
            this.hostTB = new System.Windows.Forms.TextBox();
            this.sendMailBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sendernameTB = new System.Windows.Forms.TextBox();
            this.countLbl = new System.Windows.Forms.Label();
            this.testMailBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.portTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.excelGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // excelGV
            // 
            this.excelGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.excelGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.email,
            this.var1,
            this.status});
            this.excelGV.Location = new System.Drawing.Point(12, 115);
            this.excelGV.Name = "excelGV";
            this.excelGV.RowHeadersWidth = 51;
            this.excelGV.RowTemplate.Height = 29;
            this.excelGV.Size = new System.Drawing.Size(881, 571);
            this.excelGV.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // var1
            // 
            this.var1.HeaderText = "var1";
            this.var1.MinimumWidth = 6;
            this.var1.Name = "var1";
            this.var1.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uploadExcelBtn
            // 
            this.uploadExcelBtn.Location = new System.Drawing.Point(12, 12);
            this.uploadExcelBtn.Name = "uploadExcelBtn";
            this.uploadExcelBtn.Size = new System.Drawing.Size(170, 45);
            this.uploadExcelBtn.TabIndex = 2;
            this.uploadExcelBtn.Text = "Upload Excel";
            this.uploadExcelBtn.UseVisualStyleBackColor = true;
            this.uploadExcelBtn.Click += new System.EventHandler(this.uploadExcelBtn_Click);
            // 
            // uploadTemplateBtn
            // 
            this.uploadTemplateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uploadTemplateBtn.Location = new System.Drawing.Point(1192, 12);
            this.uploadTemplateBtn.Name = "uploadTemplateBtn";
            this.uploadTemplateBtn.Size = new System.Drawing.Size(180, 45);
            this.uploadTemplateBtn.TabIndex = 3;
            this.uploadTemplateBtn.Text = "Upload Email Template";
            this.uploadTemplateBtn.UseVisualStyleBackColor = true;
            this.uploadTemplateBtn.Click += new System.EventHandler(this.uploadTemplateBtn_Click);
            // 
            // fromEmailTB
            // 
            this.fromEmailTB.Location = new System.Drawing.Point(115, 259);
            this.fromEmailTB.Name = "fromEmailTB";
            this.fromEmailTB.Size = new System.Drawing.Size(257, 27);
            this.fromEmailTB.TabIndex = 4;
            // 
            // subjectTB
            // 
            this.subjectTB.Location = new System.Drawing.Point(115, 330);
            this.subjectTB.Name = "subjectTB";
            this.subjectTB.Size = new System.Drawing.Size(257, 27);
            this.subjectTB.TabIndex = 5;
            // 
            // hostTB
            // 
            this.hostTB.Location = new System.Drawing.Point(115, 25);
            this.hostTB.Name = "hostTB";
            this.hostTB.Size = new System.Drawing.Size(257, 27);
            this.hostTB.TabIndex = 6;
            this.hostTB.Text = "smtp.hostinger.com";
            // 
            // sendMailBtn
            // 
            this.sendMailBtn.Location = new System.Drawing.Point(278, 368);
            this.sendMailBtn.Name = "sendMailBtn";
            this.sendMailBtn.Size = new System.Drawing.Size(94, 29);
            this.sendMailBtn.TabIndex = 7;
            this.sendMailBtn.Text = "Send";
            this.sendMailBtn.UseVisualStyleBackColor = true;
            this.sendMailBtn.Click += new System.EventHandler(this.sendMailBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.sendernameTB);
            this.groupBox1.Controls.Add(this.countLbl);
            this.groupBox1.Controls.Add(this.testMailBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.passwordTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.emailTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.portTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hostTB);
            this.groupBox1.Controls.Add(this.fromEmailTB);
            this.groupBox1.Controls.Add(this.sendMailBtn);
            this.groupBox1.Controls.Add(this.subjectTB);
            this.groupBox1.Location = new System.Drawing.Point(952, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 473);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sender name";
            // 
            // sendernameTB
            // 
            this.sendernameTB.Location = new System.Drawing.Point(115, 289);
            this.sendernameTB.Name = "sendernameTB";
            this.sendernameTB.Size = new System.Drawing.Size(257, 27);
            this.sendernameTB.TabIndex = 19;
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Location = new System.Drawing.Point(322, 400);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(0, 20);
            this.countLbl.TabIndex = 18;
            // 
            // testMailBtn
            // 
            this.testMailBtn.Location = new System.Drawing.Point(278, 157);
            this.testMailBtn.Name = "testMailBtn";
            this.testMailBtn.Size = new System.Drawing.Size(94, 29);
            this.testMailBtn.TabIndex = 17;
            this.testMailBtn.Text = "Test";
            this.testMailBtn.UseVisualStyleBackColor = true;
            this.testMailBtn.Click += new System.EventHandler(this.testMailBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Password";
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(115, 124);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(257, 27);
            this.passwordTB.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(115, 91);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(257, 27);
            this.emailTB.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Port";
            // 
            // portTB
            // 
            this.portTB.Location = new System.Drawing.Point(115, 58);
            this.portTB.Name = "portTB";
            this.portTB.Size = new System.Drawing.Size(86, 27);
            this.portTB.TabIndex = 11;
            this.portTB.Text = "587";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Host";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sender email";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 760);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "developed by techvestors.tech";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 789);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uploadTemplateBtn);
            this.Controls.Add(this.uploadExcelBtn);
            this.Controls.Add(this.excelGV);
            this.Name = "Form1";
            this.Text = "Bulk Email";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.excelGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView excelGV;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn var1;
        private DataGridViewTextBoxColumn status;
        private ContextMenuStrip contextMenuStrip1;
        private Button uploadExcelBtn;
        private Button uploadTemplateBtn;
        private TextBox fromEmailTB;
        private TextBox subjectTB;
        private TextBox hostTB;
        private Button sendMailBtn;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox portTB;
        private Label label6;
        private TextBox passwordTB;
        private Label label5;
        private TextBox emailTB;
        private Button testMailBtn;
        private Label countLbl;
        private Label label7;
        private Label label8;
        private TextBox sendernameTB;
    }
}