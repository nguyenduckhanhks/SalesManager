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
    public partial class changePassword : Form
    {
        public changePassword()
        {
            InitializeComponent();
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            if (testChangePassWord() == "")
            {
                changePasswordDAO.Instance.changePassWord(tbUserName.Text, tbOldPW.Text, tbNewPW.Text);
                MessageBox.Show("Đổi mật khẩu thành công", "thông báo");
                this.Hide();
            }
            else MessageBox.Show(testChangePassWord(), "error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        string testChangePassWord()
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.ACOUNT");
            foreach (DataRow item in table.Rows)
            {
                if (item["userName"].ToString() == tbUserName.Text)
                {
                    if (item["passwords"].ToString() == tbOldPW.Text)
                    {
                        if (tbNewPW.Text == tbRenewPW.Text) return ""; else return "Mật khẩu không giống nhau";
                    }
                    else return "Mật khẩu không chính xác";
                }
                else return "Tên tài khoản không chính xác";
            }
            return "";
        }
    }
}
