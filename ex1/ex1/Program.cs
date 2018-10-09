using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ex1.Exercises;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercises.Exercise1.ReverseArray();
            //Exercises.Exercise2.CulculateFormula();
            //Exercises.Exercise3.DigitVowel();
            //Exercise4.EvenOrOdd();
            //Exercises.Exercise5.GreatestNumber();
            //Exercises.Exercise6.SubjectsMarks();
            //Exercises.Exercise7.GradeEquivalentDescription();
            //Exercises.Exercise9.MaxElementOfArray();
            //Exercises.Exercise10.ReverseArray();
            //Exercises.Exercise11.FormatDataTime();
            //Exercises.Exercise12.DataTimeAddDays();
            //Exercises.Exercise13.DateCompare();
            //Exercises.Exercise14.Hours();

            //Student student1 = new Student("BOb", "Bubbum", "12.12.2002");
            //student1.DsplayStudentInfo();
            //Console.WriteLine($"Average student1 mark: {student1.GetAverageMark(3, 2, 4, 1, 5)}");
            
            //Student student2 = new Student("Carl", "Carlito", "11.11.2001");
            //student2.DsplayStudentInfo();
            //Console.WriteLine($"Average student2 mark: {student1.GetAverageMark(1, 1, 1, 1, 1)}");
            //Console.ReadLine();

            Employee employee1 = new Employee();
            employee1.Name = "Tomwerwrwrwrsergwrgwrtgrwgtwrgtrwtgwrgtwrgtrwgt";
            employee1.Surname = "e5p8";

            Employee employee2 = new Employee("Gaga","Lady", 200);
            employee1.DisplayEmployeeInfo();
            employee2.DisplayEmployeeInfo();
            employee1.GetEmployeeSalaryPerYear(200);
            Console.ReadLine();

        }
    }
}

