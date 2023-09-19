using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.DL;

namespace FinalProject.BL
{
    public class Orders
    {
        private List<Drink> dinks;
        private bool payment;
        private int IDOrder;
        private int IDDeliver;

        public List<Drink> Dinks { get => dinks; set => dinks = value; }
        public bool Payment { get => payment; set => payment = value; }
        public int IDOrder1 { get => IDOrder; set => IDOrder = value; }
        public int IDDeliver1 { get => IDDeliver; set => IDDeliver = value; }

        public Orders(List<Drink> Drinks, bool Payment, int IDOrder1, int IDDeliver1)
        {
            this.Dinks = Drinks;
            this.Payment = Payment;
            this.IDOrder1 = IDOrder1;
            this.IDDeliver1 = IDDeliver1;

        }
    }
}