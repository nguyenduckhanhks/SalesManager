using BanHang0._1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DTO
{
    class HistoryLogin
    {
        private string id;

        public string Id { get => id; set => id = value; }
        public string IdAcount { get => idAcount; set => idAcount = value; }
        public string DateLogin { get => dateLogin; set => dateLogin = value; }

        private string idAcount;

        private string dateLogin;

        public HistoryLogin(string username, string password)
        {
            this.id = RandomIdDAO.Instance.randomID("HISTORYLOGIN");
            this.idAcount = DataProvider.Instance.ExcuteQuery("EXEC dbo.FlogIn @username = '" + username + "', @password = '" + password + "' ").Rows[0]["id"].ToString();
            this.dateLogin = DateTime.Now.ToString("yyyyMMdd");
        }

    }
}
