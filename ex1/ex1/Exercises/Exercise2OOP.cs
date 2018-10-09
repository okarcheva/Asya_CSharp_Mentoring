using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    class Employee
    {
        private double _salary;
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length>20)
                {
                    Console.WriteLine($"Shoul be not more than 20 characters");
                }
                else
                {
                    _name = value;
                }
            }
        }

        private string _surname;
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (value.Length>20)

                {
                    Console.WriteLine($"Shoul be not more than 20 characters");
                }
                else
                {
                    _surname = value;
                }
            }
        }

        public double Salary { get; set; }

        public Employee()
        {
        }

        public Employee(string name, string surname, double salary)
        {
            _name = name;
            _surname = surname;
            _salary = salary;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name:{Name}, Surname: {_surname}");
        }

        public void GetEmployeeSalaryPerYear(double Salary)
        {
            Console.WriteLine($"Salary: {Salary}");
        }


    }
}
