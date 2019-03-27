using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    //Interfaces are used to specify methods that a derived class will have access to, can be seen as a contract

    class InterfaceDemo
    {
        public static void ThisMain()
        {
            Student student = new Student();
            student.Name = "Interface Shai";
            student.PrintName();
            Console.ReadLine();
        }
    }

    //Interface
    interface IPerson
    {
        void PrintName();
    }

    //Class that inherits interface
    public class Student : IPerson
    {
        public string Name { get; set; }
        public void PrintName()
        {
           Console.WriteLine($"Student name is: {Name}");
        }
    }
}
