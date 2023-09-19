using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    public class ShopkeeperBL
    {
        private string name;
        private string cnic;
        private string area;
        private string phone;
        private string location;
        private int id;

        public string Name { get => name; set => name = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string Area { get => area; set => area = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Location { get => location; set => location = value; }
        public int Id { get => id; set => id = value; }

        public ShopkeeperBL(string Name,string Cnic,string Area,string Phone,string Location,int Id)
        {
            this.Name = Name;
            this.Cnic = Cnic;
            this.Area = Area;
            this.Phone = Phone;
            this.Location = Location;
            this.Id = Id;

        }
    }
}
