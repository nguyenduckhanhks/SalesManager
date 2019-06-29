using BanHang0._1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DTO
{
    class Bill
    {
        private string id;
        public string Id { get => id;  set => id = value; }

        private string nameSale;
        public string NameSale { get => nameSale; set => nameSale = value; }

        private DateTime? timeCheckIn;
        public DateTime? TimeCheckIn { get => timeCheckIn; set => timeCheckIn = value; }

        private float moneyBill;
        public float MoneyBill { get => moneyBill; set => moneyBill = value; }
        public string IdAcount { get => idAcount; set => idAcount = value; }

        private string idAcount;

        public Bill(string idAcount,DateTime? timeCheckin, float moneyBill)
        {
            this.id = RandomIdDAO.Instance.randomID("BILL");
            this.idAcount = idAcount;
            this.timeCheckIn = timeCheckin;
            this.moneyBill = moneyBill;
        }

        public Bill(DataRow row)
        {
            this.id = row["id"].ToString();
            this.nameSale = DataProvider.Instance.ExcuteQuery("select dbo.ACOUNT.name from dbo.ACOUNT where id = '"+ row["idAcount"].ToString() + @"'").Rows[0]["name"].ToString();
            if(row["dateCheckIn"].ToString() != "")
                this.timeCheckIn = (DateTime?)row["dateCheckIn"];
            this.moneyBill = float.Parse(row["moneyBill"].ToString());
            this.idAcount = row["idAcount"].ToString(); 
        }

    }
}
