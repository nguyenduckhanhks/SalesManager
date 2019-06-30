using BanHang0._1.DAO;
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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void ĐăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp su = new SignUp();
            su.ShowDialog();
            this.Show();
        }

        private void ĐổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePassword cp = new changePassword();
            cp.ShowDialog();
        }

        private void KhoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Thủ_Kho tk = new Thủ_Kho();
            tk.Show();
        }

        private void BánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Bán_Hàng bh = new Bán_Hàng();
            bh.Show();
        }

        private void AdminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvKho.DataSource = ShowAcountDAO.Instance.GetAcountTable("Admin");
        }

        private void ThủKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvKho.DataSource = ShowAcountDAO.Instance.GetAcountTable("Thủ Kho");
        }

        private void KếToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvKho.DataSource = ShowAcountDAO.Instance.GetAcountTable("Kế Toán");
        }

        private void NhânViênBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvKho.DataSource = ShowAcountDAO.Instance.GetAcountTable("Nhân Viên Bán Hàng");
        }

        private void TấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvKho.DataSource = DataProvider.Instance.ExcuteQuery("select * from dbo.ACOUNT");
        }

        private void Btrepair_Click(object sender, EventArgs e)
        {
            UpdateAcount ua = new UpdateAcount();
            ua.ShowDialog();
        }

        private void ĐăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TàiChínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kế_Toán kt = new Kế_Toán();
            kt.ShowDialog();
            this.Dispose();
        }
    }
}
