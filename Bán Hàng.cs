using BanHang0._1.DAO;
using BanHang0._1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHang0._1
{
    public partial class Bán_Hàng : Form
    {
        static int isNewBill = 1;
        static float Total = 0;
        public Bán_Hàng()
        {
            InitializeComponent();

            pnBill.Hide();
            pnBillInnfor.Show();
            isNewBill = 1;
            Total = 0;
            loadCatalogy();
            DataTable Table = DataProvider.Instance.ExcuteQuery("select * from dbo.HISTORYLOGIN");
            string s = Table.Rows[Table.Rows.Count - 1]["idAcount"].ToString();
            Table = DataProvider.Instance.ExcuteQuery("select * from dbo.ACOUNT where id = '" + s + @"'");
            s = Table.Rows[0]["typeWord"].ToString();
            if (s != "Admin") btAdmin.Hide(); 
        }

        private void ĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePassword cp = new changePassword();
            cp.ShowDialog();
        }

        private void LịchSửĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNewBill = 0;
            Total = 0;
            pnBill.Show();
            pnBillInnfor.Hide();
            lvbill.Items.Clear();
            for(int i = 0; i < billDAO.Instance.GetBills().Count ; i++)
            {
                Bill bill = billDAO.Instance.GetBills()[i];
                ListViewItem listitem = new ListViewItem((i + 1).ToString());
                listitem.SubItems.Add(bill.TimeCheckIn.Value.ToString("dd/MM/yyyy"));
                listitem.SubItems.Add(bill.MoneyBill.ToString());
                listitem.SubItems.Add(bill.NameSale);
                lvbill.Items.Add(listitem);

                Button bt = new Button() { Width = 50, Height = 20 };
                bt.Location = new Point(445, 26+20*i);
                bt.Text = "Xem";
                bt.Tag = bill;
                pnBill.Controls.Add(bt);
                bt.Click += Bt_Click;
            }
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            isNewBill = 0;
            Total = 0;

            lvBillInfor.Items.Clear();

            string idBill = ((sender as Button).Tag as Bill).Id;

            pnBill.Hide();

            DataTable table = DataProvider.Instance.ExcuteQuery("select * from dbo.BILLINFOR as bi, dbo.ITEM as it where bi.idBill = '" + idBill + @"' and bi.idItem = it.id ");

            float total = 0;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(table.Rows[i]["name"].ToString());
                item.SubItems.Add(table.Rows[i]["countItems"].ToString());
                float money = int.Parse(table.Rows[i]["countItems"].ToString()) * float.Parse(table.Rows[i]["price"].ToString());
                total = total + money;
                item.SubItems.Add(money.ToString());
                if (i == table.Rows.Count - 1) item.SubItems.Add(total.ToString());
                lvBillInfor.Items.Add(item);
            }
            pnBillInnfor.Show();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBill.Hide();
            pnBillInnfor.Show();
            lvBillInfor.Items.Clear();
            isNewBill = 1;
            Total = 0;
            lbTotal.Text = "0.0";
        }

        private void BtPay_Click(object sender, EventArgs e)
        {
            string s = AddHistoryLoginDAO.Instance.idLoginNow();
            Bill bill = new Bill(AddHistoryLoginDAO.Instance.idLoginNow(), DateTime.Now, float.Parse(lbTotal.Text));
            billDAO.Instance.addData(bill);
            
            for(int i = lvBillInfor.Items.Count - 1; i >=0; i--)
            {
                BillInfor billInfor = new BillInfor(lvBillInfor.Items[i].SubItems[1].Text,lvBillInfor.Items[i].SubItems[2].Text, bill.Id);
                BillInforDAO.Instance.AddData(billInfor);
                ItemDAO.Instance.updateItem(billInfor);
            }

            MoneyDAO.Instance.updateMoneyAdd(Total, "đơn hàng");

            MessageBox.Show("Số tiền: " + lbTotal.Text);
            lvBillInfor.Clear();
            lbTotal.Text = "0.0";
            Total = 0;
            
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (isNewBill > 0 && testNewBill() == "")
            {
                ListViewItem item = new ListViewItem(isNewBill.ToString());
                isNewBill++;

                item.SubItems.Add(cbItem.Text);
                item.SubItems.Add(nudCountItem.Value.ToString());
                item.SubItems.Add(lbMoney.Text);
                lvBillInfor.Items.Add(item);
                Total = Total + float.Parse(lbMoney.Text);
                lbTotal.Text = Total.ToString();
            }
            else MessageBox.Show(testNewBill());
        }

        private string testNewBill()
        {
            DataTable catalogy = DataProvider.Instance.ExcuteQuery("select*from dbo.ITEMCATALOGY where name = '"+cbType.Text+@"'");
            if (catalogy.Rows.Count == 0) return "Cần chọn đúng loại mặt hàng";
            else
            {
                DataTable items = DataProvider.Instance.ExcuteQuery("select*from dbo.ITEM where name = '" + cbItem.Text + @"'");
                if (items.Rows.Count == 0) return "Cần chọn đúng tên mặt hàng";
                else if (nudCountItem.Value > int.Parse(items.Rows[0]["countItem"].ToString())) return "Không đủ hàng để bán";
            }
            if (nudCountItem.Value == 0) return "Vui lòng chọn số lượng hàng";
            if (isNewBill == 0) return "Vui lòng tạo mới đơn hàng";
            return "";
        }

        private void CbItem_TextChanged(object sender, EventArgs e)
        {
            float price = 0;
            DataTable items = DataProvider.Instance.ExcuteQuery("select*from dbo.ITEM where name = '" + cbItem.Text + @"'");
            if (items.Rows.Count > 0)
            {
                price = float.Parse(items.Rows[0]["price"].ToString()) * float.Parse(nudCountItem.Value.ToString());
            }
            lbMoney.Text = price.ToString();
        }

        private void NudCountItem_ValueChanged(object sender, EventArgs e)
        {
            float price = 0;
            DataTable items = DataProvider.Instance.ExcuteQuery("select*from dbo.ITEM where name = '" + cbItem.Text + @"'");
            if (items.Rows.Count > 0)
            {
                price = float.Parse(items.Rows[0]["price"].ToString()) * float.Parse(nudCountItem.Value.ToString());
            }
            lbMoney.Text = price.ToString();
        }

        private void loadCatalogy()
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select*from dbo.ITEMCATALOGY ");
            foreach(DataRow item in table.Rows)
            {
                cbType.Items.Add(item["name"]);
            }
        }

        private void CbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbItem.Items.Clear();

            DataTable table = DataProvider.Instance.ExcuteQuery("select*from dbo.ITEMCATALOGY where name = '" + cbType.Text + @"'");
            table = DataProvider.Instance.ExcuteQuery("select * from dbo.ITEM where idCatalogy = '"+table.Rows[0]["id"]+@"'");
            foreach(DataRow item in table.Rows)
            {
                cbItem.Items.Add(item["name"]);
            }
        }

        private void BtAdmin_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Dispose();
            ad.Show();
        }
    }
}
