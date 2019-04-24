using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_24._04._2019_
{
    class Program
    {
        static void Main (string[] args)
        {
            Group group = new Group();
            Student student = new Student();

            student.Group = group;

            Console.Write("Please, Enter your name: ");
            student.Name = Console.ReadLine();
            Console.Write("Please, Enter your surname: ");
            student.Surname = Console.ReadLine();

            Console.Write("Please, Enter your group: ");
            group.Name = Console.ReadLine();

            Console.WriteLine("Hello! {0} {1}. Your group: {2}.", student.Name, student.Surname, student.Group.Name);
            Console.ReadLine();
        }
    }

    class Group
    {
        public string Name { get; set; }

    }

    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Group Group { get; set; }


    }
}
