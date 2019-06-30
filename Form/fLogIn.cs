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
    public partial class fLogIn : Form
    {
        public fLogIn()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtLogIn_Click(object sender, EventArgs e)
        {
            string username = tbUserName.Text;
            string password = tbPassWord.Text;
            string query = "EXEC dbo.FlogIn @username = '" + username+ "' , @password = '"+ password+ "' ";

            for (int i = password.Length-1 ; i >= 0; i--)
            {
                if (char.Parse("'") == password[i]) { query = ""; break; }
            }

            if(query != "")
            {
                if (DataProvider.Instance.ExcuteQuery(query).Rows.Count > 0)
                {
                    this.Hide();
                    DataTable table = DataProvider.Instance.ExcuteQuery(query);
                    HistoryLogin hl = new HistoryLogin(username, password);
                    AddHistoryLoginDAO.Instance.AddData(hl);
                    switch(table.Rows[0]["typeWord"].ToString())
                    {
                        case "Admin":
                            {
                                Admin ad = new Admin();
                                ad.ShowDialog();
                                break;
                            }
                        case "Thủ Kho":
                            {
                                Thủ_Kho th = new Thủ_Kho();
                                th.ShowDialog();
                                break;
                            }
                        case "Kế Toán":
                            {
                                Kế_Toán kt = new Kế_Toán();
                                kt.ShowDialog();
                                break;
                            }
                        case "Nhân Viên Bán Hàng":
                            {
                                Bán_Hàng bh = new Bán_Hàng();
                                bh.ShowDialog();
                                break;
                            }
                    }
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Nhập sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không được có ký tự '", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        }
    }
}
