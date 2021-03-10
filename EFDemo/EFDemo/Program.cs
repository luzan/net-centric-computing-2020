using EFDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //insertStudent();
            readStudent();
            Console.WriteLine("Updating");
            //updateStudent();
            deleteStudent();
            Console.WriteLine("Final Data");
            readStudent();

            Console.ReadKey();
        }

        static void insertStudent()
        {
            // creating a new instance of DbContext Class
            using(var db = new SchoolContext())
            {
                Student std = new Student();
                std.Name = "Luzan Baral";
                db.Add(std);

                std = new Student();
                std.Name = "Roshan Gurung";
                db.Add(std);

                db.SaveChanges();
            }
        }

        static void readStudent()
        {
            using(var db =  new SchoolContext())
            {
                List<Student> students = db.Students.ToList();
                foreach (Student p in students)
                {
                    Console.WriteLine("{0} {1}", p.StudentId, p.Name);
                }
            }
        }

        static void updateStudent()
        {
            using (var db = new SchoolContext())
            {
                Student std = db.Students.Find(1);
                std.Name = "Ramesh Adhikari";
                db.SaveChanges();
            }
            return;
        }

        static void deleteStudent()
        {
            using (var db = new SchoolContext())
            {

                Student std = db.Students.Find(1);
                db.Students.Remove(std);
                db.SaveChanges();
            }
            return;
        }
    }
}
