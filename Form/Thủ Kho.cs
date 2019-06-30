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
    public partial class Thủ_Kho : Form
    {
        private static int isNew = 0;
        public Thủ_Kho()
        {
            InitializeComponent();
            loadCatalogy();

            isNew = 1;

            DataTable Table = DataProvider.Instance.ExcuteQuery("select * from dbo.HISTORYLOGIN");
            string s = Table.Rows[Table.Rows.Count - 1]["idAcount"].ToString();
            Table = DataProvider.Instance.ExcuteQuery("select * from dbo.ACOUNT where id = '" + s + @"'");
            s = Table.Rows[0]["typeWord"].ToString();
            if (s != "Admin") btAdmin.Hide();
        }

        private void LịchSửĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNew = 0;
            lvItem.Items.Clear();
            List<House> houses = HouseDAO.Instance.GetListItemInHouse();
            for(int i = 0; i < houses.Count; i++ )
            {
                ListViewItem listViewItem = new ListViewItem((i + 1).ToString());
                listViewItem.SubItems.Add(houses[i].Name);

                DataTable table = DataProvider.Instance.ExcuteQuery("select * from dbo.ITEMCATALOGY where id = '" + houses[i].IdCatalogy + @"'");
                listViewItem.SubItems.Add(table.Rows[0]["name"].ToString());
                listViewItem.SubItems.Add(houses[i].CountItem.ToString());
                listViewItem.SubItems.Add(houses[i].Price.ToString());
                DateTime dt = DateTime.Parse(houses[i].DateAddItem);
                listViewItem.SubItems.Add(dt.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(houses[i].Note);
                lvItem.Items.Add(listViewItem);
            }
        }

        private void KhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNew = 0;
            lvItem.Items.Clear();
            List <Item> items = ItemDAO.Instance.getListItem();
            for(int i = 0; i < items.Count; i++)
            {
                ListViewItem listViewItem = new ListViewItem((i + 1).ToString());
                listViewItem.SubItems.Add(items[i].Name);

                DataTable table = DataProvider.Instance.ExcuteQuery("select * from dbo.ITEMCATALOGY where id = '" + items[i].IdCatalogy + @"'");
                listViewItem.SubItems.Add(table.Rows[0]["name"].ToString());

                listViewItem.SubItems.Add(items[i].CountItem.ToString());
                listViewItem.SubItems.Add(items[i].Price.ToString());
                listViewItem.SubItems.Add("");
                listViewItem.SubItems.Add(items[i].Note);
                lvItem.Items.Add(listViewItem);
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (isNew > 0 && testInpuData() == "")
            {
                ListViewItem listViewItem = new ListViewItem((isNew).ToString());
                isNew++;
                listViewItem.SubItems.Add(cbItem.Text);
                listViewItem.SubItems.Add(cbType.Text);
                listViewItem.SubItems.Add(nudCountItem.Value.ToString());
                listViewItem.SubItems.Add(nudPrice.Value.ToString());
                listViewItem.SubItems.Add(DateTime.Now.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(tbNote.Text);
                lvItem.Items.Add(listViewItem);
            }
            else MessageBox.Show(testInpuData());
        }

        private string testInpuData()
        {
            if (isNew == 0) return "Vui lòng tạo mới bảng để nhập hàng";
            if (cbType.Text == "") return "Vui lòng chọn loại mặt hàng";
            if (cbItem.Text == "") return "Vui lòng chọn tên sản phẩm";
            if (nudCountItem.Value == 0) return "Vui lòng chọn số lượn sản phẩm";
            if (nudPrice.Value == 0) return "Vui lòng chọn giá cho sản phầm";
            return "";
        }

        private void loadCatalogy()
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select*from dbo.ITEMCATALOGY ");
            foreach (DataRow item in table.Rows)
            {
                cbType.Items.Add(item["name"]);
            }
        }

        private void CbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbItem.Items.Clear();

            DataTable table = DataProvider.Instance.ExcuteQuery("select*from dbo.ITEMCATALOGY where name = '" + cbType.Text + @"'");
            table = DataProvider.Instance.ExcuteQuery("select * from dbo.ITEM where idCatalogy = '" + table.Rows[0]["id"] + @"'");
            foreach (DataRow item in table.Rows)
            {
                cbItem.Items.Add(item["name"]);
            }
        }

        private void BtPay_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lvItem.Items.Count ; i++)
            {
                DataTable table = DataProvider.Instance.ExcuteQuery("select * from dbo.ITEMCATALOGY where name = '" + lvItem.Items[i].SubItems[2].Text + @"'");
                if(table.Rows.Count == 0)
                {
                    Catalogy catalogy = new Catalogy(lvItem.Items[i].SubItems[2].Text);
                    CatalogyDAO.Instance.AddCatalogy(catalogy);
                    Item item = new Item(lvItem.Items[i].SubItems[1].Text, float.Parse(lvItem.Items[i].SubItems[4].Text), int.Parse(lvItem.Items[i].SubItems[3].Text), AddHistoryLoginDAO.Instance.idLoginNow(), catalogy.Id, lvItem.Items[i].SubItems[6].Text);
                    ItemDAO.Instance.AddNewItem(item);
                    House house = new House(item.Id, item.Name, item.Price, item.CountItem, item.Note, item.IdCatalogy, DateTime.Now.ToString("yyyyMMdd"));
                    HouseDAO.Instance.AddData(house);
                }
                else
                {
                    string idCatalogy = table.Rows[0]["id"].ToString();
                    table = DataProvider.Instance.ExcuteQuery("select * from dbo.ITEM where name = '" + lvItem.Items[i].SubItems[1].Text + @"' and idCatalogy = '"+table.Rows[0]["id"].ToString()+@"'");
                    if(table.Rows.Count == 0)
                    {
                        Item item = new Item(lvItem.Items[i].SubItems[1].Text, float.Parse(lvItem.Items[i].SubItems[4].Text), int.Parse(lvItem.Items[i].SubItems[3].Text), AddHistoryLoginDAO.Instance.idLoginNow(), idCatalogy, lvItem.Items[i].SubItems[6].Text);
                        ItemDAO.Instance.AddNewItem(item);
                        House house = new House(item.Id, item.Name, item.Price, item.CountItem, item.Note, item.IdCatalogy, DateTime.Now.ToString("yyyyMMdd"));
                        HouseDAO.Instance.AddData(house);
                    }
                    else
                    {
                        Item item = new Item(table.Rows[0]);
                        item.CountItem = int.Parse(lvItem.Items[i].SubItems[3].Text);
                        ItemDAO.Instance.updateAddItem(item);
                        House house = new House(item.Id, item.Name, item.Price, item.CountItem, item.Note, item.IdCatalogy, DateTime.Now.ToString("yyyyMMdd"));
                        HouseDAO.Instance.AddData(house);
                    }
                }
                
            }
            MessageBox.Show("Nhập hàng thành công");
            isNew = 0;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNew = 1;
            lvItem.Items.Clear();
        }

        private void BtAdmin_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Dispose();
            ad.Show();
        }

        private void ĐăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
