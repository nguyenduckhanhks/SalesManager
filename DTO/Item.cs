using BanHang0._1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DTO
{
    class Item
    {
        private string id;

        private string name;

        private float price;

        private int countItem;

        private string idAcount;

        private string idCatalogy;

        private string note;

        public string Id { get => id; private set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int CountItem { get => countItem; set => countItem = value; }
        public string IdAcount { get => idAcount; set => idAcount = value; }
        public string IdCatalogy { get => idCatalogy; set => idCatalogy = value; }
        public string Note { get => note; set => note = value; }

        public Item(string name, float price, int countItem, string idAcount, string idCatalogy, string note)
        {
            this.id = RandomIdDAO.Instance.randomID("ITEM");
            this.name = name;
            this.price = price;
            this.countItem = countItem;
            this.idAcount = idAcount;
            this.idCatalogy = idCatalogy;
            this.note = note;
        }

        public Item(DataRow row)
        {
            this.id = row["id"].ToString();
            this.name = row["name"].ToString();
            this.price = float.Parse(row["price"].ToString());
            this.countItem = int.Parse(row["countItem"].ToString());
            this.note = row["note"].ToString();
            this.idAcount = row["idAcount"].ToString();
            this.idCatalogy = row["idCatalogy"].ToString();
        }
    }
}
