using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    //Generics allow you to enforce type safety by giving you the ability to taylor a method or class to a precise data type
    class GenericsDemo
    {
        public static void ThisMain()
        {
            List<int> list1 = new List<int>();
            List<string> list2 = new List<string>();
            List<ExampleClass> list3 = new List<ExampleClass>();

            list2.Add("Generic Shai");

            Console.WriteLine(list2[0]);
            Console.ReadLine();
        }

        public class ExampleClass
        {

        }
    }
}
