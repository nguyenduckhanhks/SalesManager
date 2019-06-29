namespace BanHang0._1
{
    partial class Bán_Hàng
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
            this.pnBillInnfor = new System.Windows.Forms.Panel();
            this.lvBillInfor = new System.Windows.Forms.ListView();
            this.STTbi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moneyItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnBill = new System.Windows.Forms.Panel();
            this.lvbill = new System.Windows.Forms.ListView();
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.money = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.acountSale = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAdmin = new System.Windows.Forms.Button();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbTypeItem = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btPay = new System.Windows.Forms.Button();
            this.lbMoney = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.nudCountItem = new System.Windows.Forms.NumericUpDown();
            this.lbItem = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchSửĐơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.pnBillInnfor.SuspendLayout();
            this.pnBill.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountItem)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnBillInnfor);
            this.panel1.Controls.Add(this.pnBill);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 502);
            this.panel1.TabIndex = 0;
            // 
            // pnBillInnfor
            // 
            this.pnBillInnfor.Controls.Add(this.lvBillInfor);
            this.pnBillInnfor.Location = new System.Drawing.Point(3, 31);
            this.pnBillInnfor.Name = "pnBillInnfor";
            this.pnBillInnfor.Size = new System.Drawing.Size(648, 468);
            this.pnBillInnfor.TabIndex = 1;
            // 
            // lvBillInfor
            // 
            this.lvBillInfor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STTbi,
            this.item,
            this.countItems,
            this.moneyItem,
            this.total});
            this.lvBillInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBillInfor.GridLines = true;
            this.lvBillInfor.Location = new System.Drawing.Point(0, 0);
            this.lvBillInfor.Name = "lvBillInfor";
            this.lvBillInfor.Size = new System.Drawing.Size(640, 471);
            this.lvBillInfor.TabIndex = 0;
            this.lvBillInfor.UseCompatibleStateImageBehavior = false;
            this.lvBillInfor.View = System.Windows.Forms.View.Details;
            // 
            // STTbi
            // 
            this.STTbi.Text = "STT";
            this.STTbi.Width = 51;
            // 
            // item
            // 
            this.item.Text = "Tên mặt hàng";
            this.item.Width = 186;
            // 
            // countItems
            // 
            this.countItems.Text = "Số lượng";
            this.countItems.Width = 91;
            // 
            // moneyItem
            // 
            this.moneyItem.Text = "Giá";
            this.moneyItem.Width = 148;
            // 
            // total
            // 
            this.total.Text = "Thành tiền";
            this.total.Width = 156;
            // 
            // pnBill
            // 
            this.pnBill.Controls.Add(this.lvbill);
            this.pnBill.Location = new System.Drawing.Point(3, 31);
            this.pnBill.Name = "pnBill";
            this.pnBill.Size = new System.Drawing.Size(660, 468);
            this.pnBill.TabIndex = 3;
            // 
            // lvbill
            // 
            this.lvbill.BackColor = System.Drawing.SystemColors.Window;
            this.lvbill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.dateSale,
            this.money,
            this.acountSale});
            this.lvbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvbill.GridLines = true;
            this.lvbill.Location = new System.Drawing.Point(0, 0);
            this.lvbill.Name = "lvbill";
            this.lvbill.Size = new System.Drawing.Size(594, 468);
            this.lvbill.TabIndex = 0;
            this.lvbill.UseCompatibleStateImageBehavior = false;
            this.lvbill.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 44;
            // 
            // dateSale
            // 
            this.dateSale.Text = "Ngày bán";
            this.dateSale.Width = 99;
            // 
            // money
            // 
            this.money.Text = "Tiền";
            this.money.Width = 151;
            // 
            // acountSale
            // 
            this.acountSale.Text = "Người bán";
            this.acountSale.Width = 297;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btAdmin);
            this.panel2.Controls.Add(this.cbItem);
            this.panel2.Controls.Add(this.cbType);
            this.panel2.Controls.Add(this.lbTypeItem);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.btPay);
            this.panel2.Controls.Add(this.lbMoney);
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Controls.Add(this.lbTotal);
            this.panel2.Controls.Add(this.nudCountItem);
            this.panel2.Controls.Add(this.lbItem);
            this.panel2.Location = new System.Drawing.Point(669, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 468);
            this.panel2.TabIndex = 2;
            // 
            // btAdmin
            // 
            this.btAdmin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmin.Location = new System.Drawing.Point(238, 430);
            this.btAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(83, 31);
            this.btAdmin.TabIndex = 4;
            this.btAdmin.Text = "Admin";
            this.btAdmin.UseVisualStyleBackColor = false;
            this.btAdmin.Click += new System.EventHandler(this.BtAdmin_Click);
            // 
            // cbItem
            // 
            this.cbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(3, 137);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(216, 33);
            this.cbItem.TabIndex = 10;
            this.cbItem.TextChanged += new System.EventHandler(this.CbItem_TextChanged);
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(89, 21);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(204, 28);
            this.cbType.TabIndex = 9;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.CbType_SelectedIndexChanged);
            // 
            // lbTypeItem
            // 
            this.lbTypeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeItem.Location = new System.Drawing.Point(0, 24);
            this.lbTypeItem.Name = "lbTypeItem";
            this.lbTypeItem.Size = new System.Drawing.Size(100, 23);
            this.lbTypeItem.TabIndex = 8;
            this.lbTypeItem.Text = "Loại:";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btAdd.Location = new System.Drawing.Point(209, 234);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 31);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btPay
            // 
            this.btPay.AutoSize = true;
            this.btPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPay.Location = new System.Drawing.Point(47, 372);
            this.btPay.Name = "btPay";
            this.btPay.Size = new System.Drawing.Size(188, 64);
            this.btPay.TabIndex = 6;
            this.btPay.Text = "Thanh Toán";
            this.btPay.UseVisualStyleBackColor = true;
            this.btPay.Click += new System.EventHandler(this.BtPay_Click);
            // 
            // lbMoney
            // 
            this.lbMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbMoney.Location = new System.Drawing.Point(47, 183);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(237, 32);
            this.lbMoney.TabIndex = 5;
            this.lbMoney.Text = "0.0";
            this.lbMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPrice
            // 
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(0, 183);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(50, 27);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Giá:";
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(7, 308);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(277, 41);
            this.lbTotal.TabIndex = 3;
            this.lbTotal.Text = "0.0";
            // 
            // nudCountItem
            // 
            this.nudCountItem.AutoSize = true;
            this.nudCountItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCountItem.Location = new System.Drawing.Point(225, 137);
            this.nudCountItem.Name = "nudCountItem";
            this.nudCountItem.Size = new System.Drawing.Size(72, 34);
            this.nudCountItem.TabIndex = 2;
            this.nudCountItem.ValueChanged += new System.EventHandler(this.NudCountItem_ValueChanged);
            // 
            // lbItem
            // 
            this.lbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.Location = new System.Drawing.Point(0, 101);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(100, 23);
            this.lbItem.TabIndex = 0;
            this.lbItem.Text = "Sản Phẩm:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(990, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem1});
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Menu";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.ĐổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(173, 26);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lịchSửĐơnHàngToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // lịchSửĐơnHàngToolStripMenuItem
            // 
            this.lịchSửĐơnHàngToolStripMenuItem.Name = "lịchSửĐơnHàngToolStripMenuItem";
            this.lịchSửĐơnHàngToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.lịchSửĐơnHàngToolStripMenuItem.Text = "Lịch sử đơn hàng";
            this.lịchSửĐơnHàngToolStripMenuItem.Click += new System.EventHandler(this.LịchSửĐơnHàngToolStripMenuItem_Click);
            // 
            // Bán_Hàng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 502);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bán_Hàng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnBillInnfor.ResumeLayout(false);
            this.pnBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCountItem)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btPay;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.NumericUpDown nudCountItem;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lịchSửĐơnHàngToolStripMenuItem;
        private System.Windows.Forms.Panel pnBill;
        private System.Windows.Forms.ListView lvbill;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lbTypeItem;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader dateSale;
        private System.Windows.Forms.ColumnHeader money;
        private System.Windows.Forms.ColumnHeader acountSale;
        private System.Windows.Forms.Panel pnBillInnfor;
        private System.Windows.Forms.ListView lvBillInfor;
        private System.Windows.Forms.ColumnHeader STTbi;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader countItems;
        private System.Windows.Forms.ColumnHeader moneyItem;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Button btAdmin;
    }
}