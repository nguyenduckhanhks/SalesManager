namespace BanHang0._1
{
    partial class SignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbPay = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btSignUp = new System.Windows.Forms.Button();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbtelephone = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbtitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbPay);
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.btSignUp);
            this.panel1.Controls.Add(this.tbPassWord);
            this.panel1.Controls.Add(this.tbUserName);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbtelephone);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.lbtitle);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 492);
            this.panel1.TabIndex = 0;
            // 
            // tbPay
            // 
            this.tbPay.BackColor = System.Drawing.Color.Silver;
            this.tbPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPay.ForeColor = System.Drawing.Color.White;
            this.tbPay.Location = new System.Drawing.Point(12, 360);
            this.tbPay.Name = "tbPay";
            this.tbPay.Size = new System.Drawing.Size(480, 30);
            this.tbPay.TabIndex = 8;
            this.tbPay.Text = "Lương";
            // 
            // cbType
            // 
            this.cbType.AutoCompleteCustomSource.AddRange(new string[] {
            "Kế toán"});
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Admin",
            "Nhân Viên Bán Hàng",
            "Kế Toán",
            "Thủ Kho"});
            this.cbType.Location = new System.Drawing.Point(313, 406);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(179, 28);
            this.cbType.TabIndex = 9;
            this.cbType.Text = "Tài Khoản";
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(385, 440);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(107, 36);
            this.btClose.TabIndex = 11;
            this.btClose.Text = "Thoát";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // btSignUp
            // 
            this.btSignUp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignUp.Location = new System.Drawing.Point(226, 440);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(107, 36);
            this.btSignUp.TabIndex = 10;
            this.btSignUp.Text = "Đăng Kí";
            this.btSignUp.UseVisualStyleBackColor = true;
            this.btSignUp.Click += new System.EventHandler(this.BtSignUp_Click);
            // 
            // tbPassWord
            // 
            this.tbPassWord.BackColor = System.Drawing.Color.Silver;
            this.tbPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassWord.ForeColor = System.Drawing.Color.White;
            this.tbPassWord.Location = new System.Drawing.Point(12, 310);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(480, 30);
            this.tbPassWord.TabIndex = 7;
            this.tbPassWord.Text = "PassWord";
            // 
            // tbUserName
            // 
            this.tbUserName.BackColor = System.Drawing.Color.Silver;
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.ForeColor = System.Drawing.Color.White;
            this.tbUserName.Location = new System.Drawing.Point(12, 260);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(480, 30);
            this.tbUserName.TabIndex = 6;
            this.tbUserName.Text = "Username ";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.Silver;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.White;
            this.tbEmail.Location = new System.Drawing.Point(12, 211);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(480, 30);
            this.tbEmail.TabIndex = 5;
            this.tbEmail.Text = "Email";
            // 
            // tbtelephone
            // 
            this.tbtelephone.BackColor = System.Drawing.Color.Silver;
            this.tbtelephone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtelephone.ForeColor = System.Drawing.Color.White;
            this.tbtelephone.Location = new System.Drawing.Point(8, 118);
            this.tbtelephone.MaxLength = 100;
            this.tbtelephone.Name = "tbtelephone";
            this.tbtelephone.Size = new System.Drawing.Size(484, 30);
            this.tbtelephone.TabIndex = 3;
            this.tbtelephone.Text = "Số Điện Thoại";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(232, 168);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(160, 27);
            this.dtpDate.TabIndex = 4;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(8, 168);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(106, 24);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Ngày Sinh";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNu);
            this.panel2.Controls.Add(this.rbNam);
            this.panel2.Location = new System.Drawing.Point(358, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 40);
            this.panel2.TabIndex = 2;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNu.Location = new System.Drawing.Point(83, 10);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(51, 24);
            this.rbNu.TabIndex = 1;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Checked = true;
            this.rbNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNam.Location = new System.Drawing.Point(3, 13);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(65, 24);
            this.rbNam.TabIndex = 0;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Silver;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.Location = new System.Drawing.Point(8, 70);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(325, 30);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "Họ Và Tên";
            // 
            // lbtitle
            // 
            this.lbtitle.Font = new System.Drawing.Font("Arial Narrow", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtitle.Location = new System.Drawing.Point(130, 6);
            this.lbtitle.Name = "lbtitle";
            this.lbtitle.Size = new System.Drawing.Size(335, 50);
            this.lbtitle.TabIndex = 0;
            this.lbtitle.Text = "Quản Lý Bán Hàng";
            this.lbtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignUp
            // 
            this.AcceptButton = this.btSignUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(545, 491);
            this.Controls.Add(this.panel1);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbtitle;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSignUp;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbtelephone;
        private System.Windows.Forms.TextBox tbPay;
    }
}