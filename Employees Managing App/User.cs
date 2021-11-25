using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_Managing_App
{
     class User : IComparable
    {
        public string name;
        public int dateOfBirth;
        public string email;

        public User() { }

        public User(string name, int dateOfBirth, string email)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
        }

        //public string PrintDetail()
        //{
        //    return $"{this.name} {this.dateOfBirth} {this.email}";
        //}

        protected virtual string PrintDetail()
        {
            return $"{this.name} {this.dateOfBirth} {this.email}";
        }
        public void UserInfo()
        {
            Console.WriteLine(this.PrintDetail());
        }

        public int CompareTo(object? obj)
        {
            User someUser = (User)obj;
            if(this.dateOfBirth < someUser.dateOfBirth) return -1;
            if(this.dateOfBirth > someUser.dateOfBirth) return 1;
            return 0;
        }
    }
}
