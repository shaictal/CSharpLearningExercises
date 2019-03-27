using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharpLearning
{
    //Abstract class is similar to interfaces,
    //Cannot be instantiated,
    //Can only inherit from one abstract class,
    //Usually consists of some implementation,
    //can specify virtual methods to force derived class to create its own implementation.
    class AbstractDemo
    {
        public static void ThisMain()
        {
            Lecturer lecturer = new Lecturer();
            lecturer.Name = "Abstract Paul";
            lecturer.PrintName();
            Console.ReadLine();
        }
    }

    public class Lecturer : Person
    {
        public string Name { get; set; }
        public override void PrintName()
        {
            Console.WriteLine($"Lecturers name is: {Name} and is {Age} years old");
        }
    }
    public abstract class Person
    {
        public int Age { get; set; } = 24;
        public abstract void PrintName();
        
    }
}
