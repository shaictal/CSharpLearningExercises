using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    //static class is a class that is used to create data or functions that do not need to be instantiated.
    //inherently sealed 
    //only contain static members
    class StaticDemo
    {
        public static void ThisMain()
        {
            //cant do the following:
            //CompanyInfo companyName = new CompanyInfo();

            Console.WriteLine("Company name: " + CompanyInfo.GetCompanyName());
            Console.ReadLine();
        }
    }

    public static class CompanyInfo
    {
        public static string GetCompanyName()
        {
            return "Pty Shai";
        }
    }
}
