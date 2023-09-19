using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    public class RiderBL:EmployeeBL
    {
        private int vehicleID;
        private string area;
        
        public int VehicleID { get => vehicleID; set => vehicleID = value; }
        public string Area { get => area; set => area = value; }
        public RiderBL(string Name, string Cnic, string Email, int Salary, string DOB, string Phone, string Password, string Role, int Id, int VehicleID, string Area) : base(Name,Cnic,Email,Salary,DOB,Phone,Password,Role,Id)
        {
            this.Name = Name;
            this.Cnic = Cnic;
            this.Email = Email;
            this.Salary = Salary;
            this.DOB = DOB;
            this.Phone = Phone;
            this.Password = Password;
            this.Role = Role;
            this.Id = Id;
            this.VehicleID = VehicleID;
            this.Area = Area;
        }
    }
}
