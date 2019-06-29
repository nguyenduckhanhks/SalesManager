using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang0._1.DTO
{
    class Acount
    {
        private string id;

        public string Id { get => id; set => id = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string dateOfBirt;
        public string DateOfBirt { get => dateOfBirt; set => dateOfBirt = value; }

        private int sex;
        public int Sex { get => sex; set => sex = value; }

        private string telephone;
        public string Telephone { get => telephone; set => telephone = value; }

        private string email;
        public string Email { get => email; set => email = value; }

        private string typeWord;
        public string TypeWord { get => typeWord; set => typeWord = value; }

        private string userName;
        public string UserName { get => userName; set => userName = value; }

        private string passWord;
        public string PassWord { get => passWord; set => passWord = value; }

        private double pay;
        public double Pay { get => pay; set => pay = value; }

    }
}
