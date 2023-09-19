using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    public class Stock
    {
        private string type;
        private int size;
        private int totalQuantity;
        private int quantityUpdate;
        private int quantityRemove;

        public string Type { get => type; set => type = value; }
        public int Size { get => size; set => size = value; }
        public int QuantityUpdate { get => quantityUpdate; set => quantityUpdate = value; }
        public int QuantityRemove { get => quantityRemove; set => quantityRemove = value; }
        public int TotalQuantity { get => totalQuantity; set => totalQuantity = value; }

        public Stock(string Type,int Size,int TotalQuantity,int QuantityUpdate,int QuantityRemove)
        {
            this.Type = Type;
            this.Size = Size;
            this.TotalQuantity = TotalQuantity;
            this.QuantityUpdate = QuantityUpdate;
            this.QuantityRemove = QuantityRemove;
        }
    }
}
