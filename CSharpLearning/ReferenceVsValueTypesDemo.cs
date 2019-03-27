using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    //Reference types vs Value Types

    //Reference types are objects that store references to the actual data
    //eg. classes, interfaces, delegates, objects and string.

    //Value types actually hold the value
    //eg. structs, enums Booleans and numeric types
    
    class ReferenceVsValueTypesDemo
    {
        //Object
        private static object Book { get; set; } = "Star Trek";

        //Delegate (function pointer)
        delegate void del(string value);

        public static void ThisMain()
        {
            del d = x => Console.WriteLine(x);

            d.Invoke(Book.ToString());
            Console.ReadLine();
        }
    }
}
