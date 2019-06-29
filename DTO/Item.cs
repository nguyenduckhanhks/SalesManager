using BanHang0._1.DAO;
using System;
using System.Collections.Generic;
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

        private DateTime? dateAddItem;

        private string idAcount;

        private string idCatalogy;

        public string Id { get => id; private set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int CountItem { get => countItem; set => countItem = value; }
        public DateTime? DateAddItem { get => dateAddItem; set => dateAddItem = value; }
        public string IdAcount { get => idAcount; set => idAcount = value; }
        public string IdCatalogy { get => idCatalogy; set => idCatalogy = value; }


        public Item(string name, float price, int countItem, DateTime? dateAddItem, string idAcount, string idCatalogy)
        {
            this.id = RandomIdDAO.Instance.randomID("ITEM");
            this.name = name;
            this.price = price;
            this.countItem = countItem;
            this.dateAddItem = dateAddItem;
            this.idAcount = idAcount;
            this.idCatalogy = idCatalogy;
        }
    }
}
