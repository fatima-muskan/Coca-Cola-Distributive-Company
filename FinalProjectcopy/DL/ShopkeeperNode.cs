using FinalProject.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DL
{
    public class ShopkeeperNode
    {

        private ShopkeeperBL data;
        private ShopkeeperNode left;
        private ShopkeeperNode right;

        public ShopkeeperBL Data { get => data; set => data = value; }
        public ShopkeeperNode Left { get => left; set => left = value; }
        public ShopkeeperNode Right { get => right; set => right = value; }
        public ShopkeeperNode()
        {
            Right = null;
            Left = null;

        }
        public ShopkeeperNode(ShopkeeperBL Data) : this()
        {
            this.Data = Data;
        }
    }
}
