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
    public partial class Kế_Toán : Form
    {
        public Kế_Toán()
        {
            InitializeComponent();
        }

        private void ĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePassword cp = new changePassword();
            cp.ShowDialog();
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtCollect_Click(object sender, EventArgs e)
        {
            if(tbNote.Text != "" && float.Parse(nudMoney.Value.ToString()) > 0)
            {
                Money mn = new Money(tbNote.Text);
                mn.Total = float.Parse(nudMoney.Value.ToString()) + mn.Total;
                MoneyDAO.Instance.Add(mn);
            }
            else
            {
                MessageBox.Show("Cần ghi rõ số tiền và lí do", "Thông báo");
            }
        }

        private void BtPay_Click(object sender, EventArgs e)
        {

            if (tbNote.Text != "" && float.Parse(nudMoney.Value.ToString()) > 0)
            {
                Money mn = new Money(tbNote.Text);
                mn.Total = 0 - float.Parse(nudMoney.Value.ToString()) + mn.Total;
                MoneyDAO.Instance.Add(mn);
            }
            else
            {
                MessageBox.Show("Cần ghi rõ số tiền và lí do", "Thông báo");
            }
        }
    }
}
