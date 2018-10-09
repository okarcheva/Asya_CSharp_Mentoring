using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    public class Student
    {
        public string _name;
        public string _surname;
        public string _dateOfBirth;
        private string _grade;
        private double _mark;

        public Student(string name, string surname, string dateOfBirth)
        {
            this._name = name;
            this._surname = surname;
            this._dateOfBirth = dateOfBirth;
        }

        public double GetAverageMark(int m, int p, int c, int b, int e)
        {
            double Averg = (m+p+c+b+e)/5;
            return Averg;
        }

        public void DsplayStudentInfo()
        {
            Console.WriteLine($"Students name:{_name}  surname:{_surname}  Date of birth:{_dateOfBirth}");
        }
    }
}
