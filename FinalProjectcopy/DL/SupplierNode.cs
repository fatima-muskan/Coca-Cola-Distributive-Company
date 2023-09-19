using FinalProject.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DL
{
    public class SupplierNode
    {
        private SupplierBL data;
        private SupplierNode left;
        private SupplierNode right;

        public SupplierBL Data { get => data; set => data = value; }
        public SupplierNode Left { get => left; set => left = value; }
        public SupplierNode Right { get => right; set => right = value; }
        public SupplierNode()
        {
            Right = null;
            Left = null;

        }
        public SupplierNode(SupplierBL Data) : this()
        {
            this.Data = Data;
        }
    }
}
