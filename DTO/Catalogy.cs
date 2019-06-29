using BanHang0._1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DTO
{
    class Catalogy
    {
        private string id;

        public string Id { get => id; private set => id = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        public Catalogy(string name)
        {
            this.id = RandomIdDAO.Instance.randomID("ITEMCATALOGY");
            this.name = name;
        }

    }
}
