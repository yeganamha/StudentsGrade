using System.Globalization;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("enter count: ");
                int CountOfStudents = Convert.ToInt32(Console.ReadLine());
                Students[] students = new Students[CountOfStudents];
                for (int i = 0; i < CountOfStudents; i++)
                {
                    Console.WriteLine("enter name: ");
                    string Name = Console.ReadLine();

                    Console.WriteLine("enter grade:  ");
                    int grade = Convert.ToInt32(Console.ReadLine());
                    students[i] = new Students(Name, grade);

                }
                   Console.WriteLine( "avarage:  " + StaticsHelper.GetAvarageGrade(students) );



        }
            
           
        }
    }
