using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.BL
{
    public class EmployeeBL
    {
        private string name;
        private string cnic;
        private string email;
        private int salary;
        private string dOB;
        private string phone;
        private string password;
        private string role;
        private int id;

        public string Name { get => name; set => name = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string Email { get => email; set => email = value; }
        public int Salary { get => salary; set => salary = value; }
        public string DOB { get => dOB; set => dOB = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public int Id { get => id; set => id = value; }

        public EmployeeBL(string Name, string Cnic, string Email, int Salary, string DOB, string Phone, string Password, string Role, int Id)

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
        }
    }
}
