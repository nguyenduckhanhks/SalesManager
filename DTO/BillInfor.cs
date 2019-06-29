using BanHang0._1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DTO
{
    class BillInfor
    {
        private string id;
        public string Id { get => id; private set => id = value; }
        
        private string idItem;
        public string IdItem { get => idItem; set => idItem = value; }

        private string idBill;
        public string IdBill { get => idBill; set => idBill = value; }

        private int countItems;
        public int CountItems { get => countItems; set => countItems = value; }

        public BillInfor(string idItem, string idBill, int countItems)
        {
            this.id = RandomIdDAO.Instance.randomID("BILLINFOR");
            this.idItem = idItem;
            this.idBill = idBill;
            this.countItems = countItems;
        }

        public BillInfor(string nameItem, string count, string idBill)
        {
            this.id = RandomIdDAO.Instance.randomID("BILLINFOR");
            this.idItem = DataProvider.Instance.ExcuteQuery("select * from dbo.Item where name = '" + nameItem + @"'").Rows[0]["id"].ToString();
            this.idBill = idBill;
            this.countItems = int.Parse(count);
        }

        public BillInfor(DataRow row)
        {
            this.id = row["id"].ToString();
            this.idItem = row["idItem"].ToString();
            this.idBill = row["idBill"].ToString();
            this.countItems = int.Parse(row["countItems"].ToString());
        }
        

    }
}
