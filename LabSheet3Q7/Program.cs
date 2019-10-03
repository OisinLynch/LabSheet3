using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entering details for school 1
            Schools sch1 = new Schools();

            //Asking user to enter the name of school 1
            Console.Write("Enter School Name: ");
            sch1.SchoolName = Console.ReadLine();

            //Asking the user to enter the number of students enrolled in school 1
            Console.Write("Enter number of students enrolled: ");
            sch1.NumOfStudents = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //Entering details for school 2
            Schools sch2 = new Schools();

            //Asking user to enter the name of school 2
            Console.Write("Enter School Name: ");
            sch2.SchoolName = Console.ReadLine();

            //Asking the user to enter the number of students enrolled in school 2
            Console.Write("Enter number of students enrolled: ");
            sch2.NumOfStudents = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //Entering details for school 3
            Schools sch3 = new Schools();

            //Asking user to enter the name of school 3
            Console.Write("Enter School Name: ");
            sch3.SchoolName = Console.ReadLine();

            //Asking the user to enter the number of students enrolled in school 3
            Console.Write("Enter number of students enrolled: ");
            sch3.NumOfStudents = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //Entering details for school 4
            Schools sch4 = new Schools();

            //Asking user to enter the name of school 4
            Console.Write("Enter School Name: ");
            sch4.SchoolName = Console.ReadLine();

            //Asking the user to enter the number of students enrolled in school 4
            Console.Write("Enter number of students enrolled: ");
            sch4.NumOfStudents = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //Displaying the details of schools
            Console.WriteLine("School Name: {0}", sch1.SchoolName);
            Console.WriteLine("Students Enrolled: {0}", sch1.NumOfStudents);
            Console.WriteLine("School Name: {0}", sch2.SchoolName);
            Console.WriteLine("Students Enrolled: {0}", sch2.NumOfStudents);
            Console.WriteLine("School Name: {0}", sch3.SchoolName);
            Console.WriteLine("Students Enrolled: {0}", sch3.NumOfStudents);
            Console.WriteLine("School Name: {0}", sch4.SchoolName);
            Console.WriteLine("Students Enrolled: {0}", sch4.NumOfStudents);

            
        }
    }
}
