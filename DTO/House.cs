using BanHang0._1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DTO
{
    class House
    {
        private string id;

        public string Id { get => id; set => id = value; }
        public string IdItem { get => idItem; set => idItem = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int CountItem { get => countItem; set => countItem = value; }
        public string Note { get => note; set => note = value; }
        public string IdCatalogy { get => idCatalogy; set => idCatalogy = value; }
        public string DateAddItem { get => dateAddItem; set => dateAddItem = value; }

        private string idItem;

        private string name;

        private float price;

        private int countItem;

        private string note;

        private string idCatalogy;

        private string dateAddItem;

        public House(DataRow row)
        {
            this.id = row["id"].ToString();
            this.idItem = row["idItem"].ToString();
            this.name = row["name"].ToString();
            this.price = float.Parse(row["price"].ToString());
            this.countItem = int.Parse(row["countItem"].ToString());
            this.note = row["note"].ToString();
            this.IdCatalogy = row["idCatalogy"].ToString();
            this.dateAddItem = row["dateAddItem"].ToString();
        }

        public House(string idItem, string name, float price, int countItem, string note, string idcatalogy, string dateAddItem)
        {
            this.id = RandomIdDAO.Instance.randomID("HOUSE");
            this.idItem = idItem;
            this.name = name;
            this.price = price;
            this.countItem = countItem;
            this.note = note;
            this.idCatalogy = idcatalogy;
            this.dateAddItem = dateAddItem;
        }
    }
}
