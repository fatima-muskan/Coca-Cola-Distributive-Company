using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.BL;

namespace FinalProject.DL
{
    public class EmployeeNode
    {
        private EmployeeBL data;
        private EmployeeNode left;
        private EmployeeNode right;

        public EmployeeBL Data { get => data; set => data = value; }
        public EmployeeNode Left { get => left; set => left = value; }
        public EmployeeNode Right { get => right; set => right = value; }

        public EmployeeNode()
        {
            Right = null;
            Left = null;

        }
        public EmployeeNode(EmployeeBL Data) : this()
        {
            this.Data = Data;
        }
    }
}
