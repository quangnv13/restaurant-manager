using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Manager.DTO
{
    public class AccountDTO
    {
        private string _employeeID;

        private string _password;

        private string _role;

        private string _office;

        public string EmployeeID { get => _employeeID; set => _employeeID = value; }
        public string Password { get => _password; set => _password = value; }
        public string Role { get => _role; set => _role = value; }
        public string Office { get => _office; set => _office = value; }

        public AccountDTO(string employeeID)
        {
            this.EmployeeID = employeeID;
        }

        public AccountDTO(string emplpyeeID, string password)
        {
            this.EmployeeID = emplpyeeID;
            this.Password = password;
        }
        public AccountDTO(string employeeID,string password,string role,string office)
        {
            this.EmployeeID = employeeID;
            this.Password = password;
            this.Role = role;
            this.Office = office;
        }
    }
}
