using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practical1c
{
    struct Student
    {
        public int sid;
        public string sname;
        public string cname;
        public int dd, mm, yy;
        public void display()
        {
            Console.WriteLine("Student Name:" + sname);
            Console.WriteLine("Student ID:" + sname);
            Console.WriteLine("Student Class:" + sname);
            Console.WriteLine("Student D.O.B: {0}/{1}/{2}",dd,mm,yy);

        }
    }
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
                 Console.Write("How many students do you want to enroll");
                 int n=int.Parse(Console.ReadLine());
                Student[] allstudents = new Student[n];

                    for (int i=0; i<n;i++)
                {
                    allstudents[i] = new Student();
                    Console.WriteLine("Enter Student Name:");
                    allstudents[i].sname = Console.ReadLine();
                    Console.WriteLine("Enter Student Id:");
                    allstudents[i].sid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Class name:");
                    allstudents[i].cname = Console.ReadLine();
                    Console.WriteLine("Enter Day of Birth:");
                    allstudents[i].dd=int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Month of Birth:");
                    allstudents[i].mm = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter year of Birth:");
                    allstudents[i].yy = int.Parse(Console.ReadLine());
                }
            Console.WriteLine("********************Accepted Student Info***********************");
            for (int i=0; i<n; i++)
            {
                Console.WriteLine("====================================================================");
                allstudents[i].display();
                Console.WriteLine("====================================================================");

            }
            Console.ReadKey();
            }
    }
}
