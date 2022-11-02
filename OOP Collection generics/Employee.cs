using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Collection_generics
{
    public class Employee
    {
        private int _id;
        private string _name;
        private string _gender;
        private int _salary;

        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Gender
        {
            get { return _gender; }
            set
            {
                if (value == "Male" || value == "Female" || value == "Other")
                {
                    _gender = value;
                }
                else
                {
                    _gender = "Unknown";
                }
            }
        }
        public int Salary { get { return _salary; } set { _salary = value; } }

        public Employee(int ID, string Name, string Gender, int Salary)
        {
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.Salary = Salary;
        }
    }
}
