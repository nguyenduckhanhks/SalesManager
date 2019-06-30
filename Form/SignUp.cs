using BanHang0._1.DAO;
using BanHang0._1.DTO;
using BanHang0._1.SigUpDAO;
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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void BtSignUp_Click(object sender, EventArgs e)
        {
            if(testAcountData() == "")
            {
                Acount acount = new Acount();
                acount.Id = RandomIdDAO.Instance.randomID("ACOUNT");
                acount.Name = tbName.Text;

                DateTime date = dtpDate.Value;
                acount.DateOfBirt = date.ToString("yyyyMMdd");

                if (rbNam.Checked) acount.Sex = 1; else acount.Sex = 0;

                acount.Telephone = tbtelephone.Text;
                acount.Email = tbEmail.Text;
                acount.TypeWord = cbType.Text;
                acount.UserName = tbUserName.Text;
                acount.PassWord = tbPassWord.Text;
                acount.Pay = double.Parse(tbPay.Text);

                addAcountDataProvider.Instance.testAcountData(acount);
                MessageBox.Show("Đăng ký thành công!", "Thông Báo");
                this.Hide();
            }
            else
            {
                MessageBox.Show(testAcountData(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private string testAcountData()
        {
            if (double.Parse(tbPay.Text) <= 0) return "Tiền Lương không hợp lệ";
            
            if (tbtelephone.Text[0] != '0' && tbtelephone.Text.Length != 10) return "Số điện thoại không hợp lệ";

            for (int i = tbPassWord.Text.Length - 1; i >= 0; i--)
            {
                if (char.Parse("'") == tbPassWord.Text[i]) { return "Mật Khẩu không hợp lệ"; }
            }

            for (int i = tbUserName.Text.Length - 1; i >= 0; i--)
            {
                if (char.Parse("'") == tbUserName.Text[i]) { return "tên tài khoản không hợp lệ"; }
            }



            List<Acount> acountList = new List<Acount>();
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.ACOUNT");
            foreach(DataRow item in table.Rows)
            {
                if (item["userName"].ToString() == tbUserName.Text && item["passwords"].ToString() == tbPassWord.Text) return "Tài khaonr này đã tồn tại; vui lòng thay đổi tài khoản khác!";
            }

            if (cbType.Text != "Admin" && cbType.Text != "Thủ Kho" && cbType.Text != "Kế Toán" && cbType.Text != "Nhân Viên Bán Hàng")
                return "Vị trí công viêc không hợp lệ";
            return "";
        }
    }
}
