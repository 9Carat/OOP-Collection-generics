using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Collection_generics
{
    public class Employee
    {
        public int ID;
        public string Name;
        public string Gender;
        public int Salary;

        public Employee(int ID, string Name, string Gender, int Salary)
        {
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.Salary = Salary;
        }
    }
}
