using FinalProject.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DL
{
    public class VehicleNode
    {
        private VehcleBL data;
        private VehicleNode left;
        private VehicleNode right;

        public VehcleBL Data { get => data; set => data = value; }
        public VehicleNode Left { get => left; set => left = value; }
        public VehicleNode Right { get => right; set => right = value; }
        public VehicleNode()
        {
            Right = null;
            Left = null;

        }
        public VehicleNode(VehcleBL Data) : this()
        {
            this.Data = Data;
        }
    }
}
