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
        public Thủ_Kho()
        {
            InitializeComponent();
        }

        private void LịchSửĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvItem.Items.Clear();
            List<House> houses = HouseDAO.Instance.GetListItemInHouse();
            for(int i = 0; i < houses.Count; i++ )
            {
                ListViewItem listViewItem = new ListViewItem((i + 1).ToString());
                listViewItem.SubItems.Add(houses[i].Name);
                listViewItem.SubItems.Add(houses[i].CountItem.ToString());
                listViewItem.SubItems.Add(houses[i].Price.ToString());
                DateTime dt = DateTime.Parse(houses[i].DateAddItem);
                listViewItem.SubItems.Add(dt.ToString("dd/MM/yyyy"));
            }
        }

        private void KhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvItem.Items.Clear();
        }
    }
}
