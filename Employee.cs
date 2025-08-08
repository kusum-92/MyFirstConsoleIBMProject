using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMProject
{
    internal class Employee : Person
    {
        public int EmployeeID { get; set; }
        public string? Role { get; set; } // ? defines nullable and denotes if you have not assigned to any value
        public string? Email { get; set; }
        public double Salary { get; set; }

        public Employee() { }

        public Employee(int employeeId, string name,string city,  int age,string role, string email,double salary)
            : base(employeeId,name,city,age)
            {
            EmployeeID = employeeId;
            Role = role;
            Email = email;
            Salary = salary;
        }
        public string GetEmployeeInfo()
        {
            return $"Employee ID: {EmployeeID},  Role: {Role}, Email: {Email}, Salary: {Salary}";
        }



    }
}
