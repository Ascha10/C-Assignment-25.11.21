using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_Managing_App
{
     class Employee : User 
    {
        public string role;
        public int salary;

        public Employee(string name, int dateOfBirth, string email, string role, int salary) : base(name, dateOfBirth, email)
        {
            this.role = role;
            this.salary = salary;
        }

        //public new string PrintDetail()
        //{
        //    return $"{this.name} {this.dateOfBirth} {this.email} {this.role} {this.salary}";
        //}

        protected override string PrintDetail()
        {
            return $"{this.name} {this.dateOfBirth} {this.email} {this.role} {this.salary}";
        }

         public void EmployeeInfo()
        {
            Console.WriteLine(this.PrintDetail());
        }
    }
}
