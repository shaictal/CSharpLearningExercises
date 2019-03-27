using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    //Polymorphism is when classes have different functionality but share the same interface
    //eg. overriding & overloading
    class PolymorphismDemo
    {
        public static void ThisMain()
        {

            //Different versions of the method are being invoked depending on the object invoking it.
            const int hours = 50;
            const int wage = 70;

            Employee emp = new Employee();
            emp.CalculateWeeklySalary(hours,wage);

            Contractor cont = new Contractor();
            cont.CalculateWeeklySalary(hours,wage);

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public virtual void CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            Console.WriteLine($"This employee worked {weeklyHours}, and paid for 40 hours at {wage} p/h. Total = {salary}");
            Console.WriteLine("----------------");
        }
    }

    public class Contractor: Employee
    {
        public virtual void CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;
            Console.WriteLine($"This employee worked {weeklyHours}, and paid for {weeklyHours} hours at {wage} p/h. Total = {salary}");
            Console.WriteLine("----------------");
        }
    }
}
