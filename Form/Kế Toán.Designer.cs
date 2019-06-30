namespace BanHang0._1
{
    partial class Kế_Toán
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
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbReason = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.btPay = new System.Windows.Forms.Button();
            this.btCollect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nudMoney = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nudMoney);
            this.panel1.Controls.Add(this.lbMoney);
            this.panel1.Controls.Add(this.lbReason);
            this.panel1.Controls.Add(this.tbNote);
            this.panel1.Controls.Add(this.btPay);
            this.panel1.Controls.Add(this.btCollect);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 592);
            this.panel1.TabIndex = 0;
            // 
            // lbMoney
            // 
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.Location = new System.Drawing.Point(621, 47);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(100, 38);
            this.lbMoney.TabIndex = 6;
            this.lbMoney.Text = "Số Tiền:";
            this.lbMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbReason
            // 
            this.lbReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReason.Location = new System.Drawing.Point(625, 138);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(100, 38);
            this.lbReason.TabIndex = 5;
            this.lbReason.Text = "Lí Do:";
            this.lbReason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(625, 190);
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(261, 244);
            this.tbNote.TabIndex = 4;
            // 
            // btPay
            // 
            this.btPay.Location = new System.Drawing.Point(796, 464);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(90, 42);
            this.btPay.TabIndex = 3;
            this.btPay.Text = "Chi";
            this.btPay.UseVisualStyleBackColor = true;
            this.btPay.Click += new System.EventHandler(this.BtPay_Click);
            // 
            // btCollect
            // 
            this.btCollect.Location = new System.Drawing.Point(625, 464);
            this.btCollect.Name = "btCollect";
            this.btCollect.Size = new System.Drawing.Size(90, 42);
            this.btCollect.TabIndex = 1;
            this.btCollect.Text = "Thu";
            this.btCollect.UseVisualStyleBackColor = true;
            this.btCollect.Click += new System.EventHandler(this.BtCollect_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 565);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.ĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // nudMoney
            // 
            this.nudMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMoney.Location = new System.Drawing.Point(629, 89);
            this.nudMoney.Name = "nudMoney";
            this.nudMoney.Size = new System.Drawing.Size(257, 27);
            this.nudMoney.TabIndex = 8;
            // 
            // Kế_Toán
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 592);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Kế_Toán";
            this.Text = "Kế_Toán";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label lbReason;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button btPay;
        private System.Windows.Forms.Button btCollect;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudMoney;
    }
}