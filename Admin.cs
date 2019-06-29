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
            panel1.Hide();
            
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
            Bán_Hàng bh = new Bán_Hàng();
            bh.Show();
        }
    }
}
