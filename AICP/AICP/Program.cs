using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AICP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to AICP (anonymous income comparison program)");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("We will now compare 2 peoples income");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string p1hr = Console.ReadLine();
            int hourly_rate_p1 = Convert.ToInt32(p1hr);

            Console.WriteLine("How many hours do you work per week?");
            string p1hpw = Console.ReadLine();
            int hours_per_week_p1 = Convert.ToInt32(p1hpw);

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string p2hr = Console.ReadLine();
            int hourly_rate_p2 = Convert.ToInt32(p2hr);

            Console.WriteLine("How many hours do you work per week?");
            string p2hpw = Console.ReadLine();
            int hours_per_week_p2 = Convert.ToInt32(p2hpw);

            int person1_salary = hourly_rate_p1* hours_per_week_p1 *52;
            int person2_salary = hourly_rate_p2 * hours_per_week_p2 *52;

            
            if (person1_salary < person2_salary)
            {
                bool comp = false;
                Console.WriteLine("Annual salary of Person 1: " + person1_salary);
                Console.WriteLine("Annual salary of Person 2: " + person2_salary);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Does Person 1 make more money than Person 2 ?" + " " + comp);
                Console.ReadLine();
            }
            else
            {
                bool comp = true;
                Console.WriteLine("Annual salary of Person 1: " + person1_salary);
                Console.WriteLine("Annual salary of Person 2: " + person2_salary);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Does Person 1 make more money than Person 2 ?" + " " + comp);
                Console.ReadLine();
            }

        }
    }
}
