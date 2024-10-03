using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGenericCollections
{
    internal class Employee
    {
        private int _id;
        private int _salary;
        private string _name;
        private string _gender;


        public int Id => _id;
        public int Salary => _salary;
        public string Name => _name;
        public string Gender => _gender;

        public Employee(int id, int salary, string name, string gender)
        {
            _id = id;
            _salary = salary;
            _name = name;
            _gender = gender;
        }
    }
}
