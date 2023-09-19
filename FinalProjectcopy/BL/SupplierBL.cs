using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    public class SupplierBL
    {
        private string name;
        private string cnic;
        private string phone;
        private int id;

        public string Name { get => name; set => name = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Id { get => id; set => id = value; }

        public SupplierBL(string Name,string Cnic,string Phone,int Id)
        {
            this.Name = Name;
            this.Cnic = Cnic;
            this.Phone = Phone;
            this.Id = Id;
        }
    }
}
