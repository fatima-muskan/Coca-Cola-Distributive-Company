using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    public class VehcleBL
    {
        private string number;
        private bool status;
        private int fuel;
        private int id;

        public string Number { get => number; set => number = value; }
        public bool Status { get => status; set => status = value; }
        public int Fuel { get => fuel; set => fuel = value; }
        public int Id { get => id; set => id = value; }
        public VehcleBL(string Number,bool Status,int Fuel,int Id)
        {
            this.Number = Number;
            this.Status = Status;
            this.Fuel = Fuel;
            this.Id = Id;
        }
    }
}
