using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DAO
{
    class changePasswordDAO
    {
        private static changePasswordDAO instance;

        public static changePasswordDAO Instance
        {
            get { if (instance == null) instance = new changePasswordDAO(); return changePasswordDAO.instance; }
            private set { changePasswordDAO.instance = value; }
        }
        private changePasswordDAO() { }

        public void changePassWord(string username, string oldpassword, string newPassWord)
        {
            string query = "update dbo.ACOUNT set passwords = '" + newPassWord + @"' where userName = '" + username + @"' and passwords='" + oldpassword + @"'";
            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
