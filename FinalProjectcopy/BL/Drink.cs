using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    public class Drink
    {
        private string type;
        private int size;
        private int quantity;

        public string Type { get => type; set => type = value; }
        public int Size { get => size; set => size = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Drink(string Type,int Size,int Quantity)
        {
            this.Type = Type;
            this.Size = Size;
            this.Quantity = Quantity;
        }
    }
}
