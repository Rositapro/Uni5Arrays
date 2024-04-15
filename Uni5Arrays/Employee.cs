using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uni5Arrays
{
    internal class Employee
    {
        private string name;
        private int salary;
        private string sex;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public Employee(string name, int salary, string sex)
        {
            this.name = name;
            this.salary = salary;
            this.sex = sex;

        }
        public Employee()
        {
            name = " ";
            salary = 0;
            sex = " ";
        }
        public override string ToString()
        {
            return "Nombre: " + name + " Salary: " + salary + " Sex: " + sex;
        }
    }
}
