using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLearning
{
    //encapsulation prevents access to implementation details
    //abstraction allows making relevant information visible
    class EncapsulationAbstractionDemo
    {
        public static void ThisMain()
        {
            const int hours = 50;
            const int wage = 70;

            Employee emp = new Employee();
            emp.CalculateWeeklySalary(hours, wage);

            Contractor cont = new Contractor();
            cont.CalculateWeeklySalary(hours, wage);

            //cant call private method as it is encapsulated within the class.
            //cont.privateMethod();

            Console.ReadLine();
        }
    }
    public class Employee2
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

    public class Contractor2 : Employee2
    {
        public virtual void CalculateWeeklySalary(int weeklyHours, int wage)
        {
            var salary = weeklyHours * wage;
            Console.WriteLine($"This employee worked {weeklyHours}, and paid for {weeklyHours} hours at {wage} p/h. Total = {salary}");
            Console.WriteLine("----------------");
        }
    }
}
