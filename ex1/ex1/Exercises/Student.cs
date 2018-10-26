using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex1.Exercises
{
    public class Student
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private string DateOfBirth { get; set; }
       
        public Student(string name, string surname, string dateOfBirth)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Students name: {Name}  surname: {Surname}  Date of birth: {DateOfBirth}");
        }

        public double GetAverageMark(Mark[] marks)
        {
            var marksCount = marks.Length;

            double marksSum = 0;

            foreach (var element in marks)
            {
                marksSum += element.Value;
            }
            var average = marksSum / marksCount;
            
            return average;
        }
    }
}
