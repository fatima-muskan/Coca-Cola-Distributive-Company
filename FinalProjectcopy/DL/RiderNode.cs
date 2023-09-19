using FinalProject.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject.DL
{
    public class RiderNode
    {

        private RiderBL data;
        private RiderNode left;
        private RiderNode right;

        public RiderBL Data { get => data; set => data = value; }
        public RiderNode Left { get => left; set => left = value; }
        public RiderNode Right { get => right; set => right = value; }

        public RiderNode()
        {
            Right = null;
            Left = null;

        }
        public RiderNode(RiderBL Data) : this()
        {
            this.Data = Data;
        }
    }
}
