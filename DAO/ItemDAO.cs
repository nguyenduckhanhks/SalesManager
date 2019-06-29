using BanHang0._1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DAO
{
    class ItemDAO
    {
        private static ItemDAO instance;
        public static ItemDAO Instance
        {
            get { if (instance == null) instance = new ItemDAO(); return ItemDAO.instance; }
            private set { ItemDAO.instance = value; }
        }

        private ItemDAO() { }

        public void updateItem(BillInfor billInfor)
        {
            int oldItems = int.Parse(DataProvider.Instance.ExcuteQuery("select * from dbo.ITEM where id = '" + billInfor.IdItem + @"'").Rows[0]["countItem"].ToString());
            string query = "update dbo.ITEM set countItem = " + (oldItems - billInfor.CountItems).ToString() + @"where id = '" + billInfor.IdItem + @"'";
            DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
