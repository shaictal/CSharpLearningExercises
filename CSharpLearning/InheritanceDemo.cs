using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    //Inheritance is when an object/class is based on a parent object/class, taking on its characteristics.
    //C# does NOT support multiple inheritance however you can implement many interfaces.
    class InheritanceDemo
    {
        public static void ThisMain()
        {
            const int hours = 50;
            const int wage = 70;

            Employee emp = new Employee();
            emp.CalculateWeeklySalary(hours, wage);

            Contractor cont = new Contractor();
            cont.CalculateWeeklySalary(hours, wage);

            Console.ReadLine();
        }
    }
    public class Employee3
    {
        public virtual void CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = 40 * wage;
            Console.WriteLine($"This employee worked {weeklyHours}, and paid for 40 hours at {wage} p/h. Total = {salary}");
            Console.WriteLine("----------------");
        }

        private void privateMethod()
        {
            //this is not accessible via the contractor.
        }
    }

    //inheritance is seen below where Contractor3 is inheriting Employee3
    public class Contractor3 : Employee3
    {
        public virtual void CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;
            Console.WriteLine($"This employee worked {weeklyHours}, and paid for {weeklyHours} hours at {wage} p/h. Total = {salary}");
            Console.WriteLine("----------------");
        }
    }
}
