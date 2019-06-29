using BanHang0._1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DAO
{
    class AddHistoryLoginDAO
    {
        private static AddHistoryLoginDAO instance;
        public static AddHistoryLoginDAO Instance
        {
            get { if (instance == null) instance = new AddHistoryLoginDAO(); return AddHistoryLoginDAO.instance; }
            private set { AddHistoryLoginDAO.instance = value; }
        }

        public void AddData(HistoryLogin hl)
        {
            string query = @"insert into dbo.HISTORYLOGIN
            (
                id,
                idAcount,
                dateLoin
            )
            values
            (
                '"+hl.Id+@"',
                '"+hl.IdAcount+@"',
                '"+hl.DateLogin+@"'
            )";
            DataProvider.Instance.ExcuteQuery(query);
        }

        public string idLoginNow()
        {
            DataTable table = DataProvider.Instance.ExcuteQuery("select * from dbo.HISTORYLOGIN");
            string s = table.Rows[table.Rows.Count - 1]["idAcount"].ToString();
            return s;
        }
    }
}
