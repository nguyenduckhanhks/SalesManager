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
    public partial class UpdateAcount : Form
    {
        public UpdateAcount()
        {
            InitializeComponent();
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            if(TestData() == "")
            {
                if (tbtelephone.Text != "") DataProvider.Instance.ExcuteQuery("update dbo.ACOUNT set telephone='" + tbtelephone.Text + @"' where userName = '" + tbUserName.Text + @"' and passwords = '" + tbPassWord.Text + @"'");
                if (tbEmail.Text != "") DataProvider.Instance.ExcuteQuery("update dbo.ACOUNT set email='" + tbEmail.Text + @"' where userName = '" + tbUserName.Text + @"' and passwords = '" + tbPassWord.Text + @"'");
                if (cbType.Text != "") DataProvider.Instance.ExcuteQuery("update dbo.ACOUNT set typeWord='" + cbType.Text + @"' where userName = '" + tbUserName.Text + @"' and passwords = '" + tbPassWord.Text + @"'");
                if (nudPay.Text != "") DataProvider.Instance.ExcuteQuery("update dbo.ACOUNT set pay='" + nudPay.Text + @"' where userName = '" + tbUserName.Text + @"' and passwords = '" + tbPassWord.Text + @"'");
                MessageBox.Show("Lưu thông tin thành công", "Thông báo");
            }
            else MessageBox.Show(TestData(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }

        private string TestData()
        {
            List<Acount> acountList = new List<Acount>();
            DataTable table = DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.ACOUNT where userName = '" + tbUserName.Text + @"' and passwords = '" + tbPassWord.Text + @"'");
            
            if (table.Rows.Count > 0)
            {
                if(nudPay.Text != "")
                if (double.Parse(nudPay.Text) <= 0) return "Tiền Lương không hợp lệ";

                if(tbtelephone.Text != "")
                if (tbtelephone.Text[0] != '0' && tbtelephone.Text.Length != 10) return "Số điện thoại không hợp lệ";

                if(cbType.Text != "")
                if (cbType.Text != "Admin" && cbType.Text != "Thủ Kho" && cbType.Text != "Kế Toán" && cbType.Text != "Nhân Viên Bán Hàng")
                    return "Vị trí công viêc không hợp lệ";
            }
            else return "tên tài khoản hoặc mật khẩu không chính xác";

            return "";
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
