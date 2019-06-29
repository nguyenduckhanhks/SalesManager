using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banHang
{
    public partial class fLogIn : Form
    {
        public fLogIn()
        {
            InitializeComponent();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác Nhận Thoát Chương Trình", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
    }
}
