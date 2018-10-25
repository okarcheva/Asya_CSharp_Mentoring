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
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length>20)
                {
                    Console.WriteLine($"Name should be not more than 20 characters");
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
                    Console.WriteLine($"Surname should be not more than 20 characters");
                }
                else
                {
                    _surname = value;
                }
            }
        }

        private double _salary;
        public double Salary { get; set; }

        public Employee()
        {
        }

        public Employee(string name, string surname, double salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name:{Name}, Surname: {Surname}, Salary per month: {Salary}");
        }

        public void GetEmployeeSalaryPerYear(double Salary)
        {
            Console.WriteLine($"Salary per year: {Salary*12}");
        }

        public void GetEmployeeSalaryWithTaxes(double Salary, double tax)
        {
           var procent = ((Salary * 12) * tax) / 100;
           Console.WriteLine($"Salary with taxes: {(Salary * 12)-procent}");
        }

    }
}
