using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.BL;

namespace FinalProject.DL
{
    public class LoginDL
    {    
        public static string CheckUser(int id,string password)
        {
            EmployeeDL BST = new EmployeeDL();
            RiderDL bst = new RiderDL();
            bst.read("Rider.csv");
            BST.read("Employee.csv");
            EmployeeBL emp = BST.search(id);
            RiderBL rider = bst.search(id);
            if(emp == null && rider != null)
            {
                if (rider.Password == password)
                {
                    return rider.Role;
                }
            }
            else if(emp!=null && rider==null)
            {
                if(emp.Password==password)
                {
                    return emp.Role;
                }
            }
            else if (id==123)
            {
                if ("abc789" == password)
                {
                    return "Manager";
                }
            }
            return null;
        }
    }
}
