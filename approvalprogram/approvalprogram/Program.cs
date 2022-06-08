using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace approvalprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Car Insurance Approval ");

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Please answer these questions");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int applicant_age = Convert.ToInt32(age);


            Console.WriteLine("Have you ever had a DUI? Answer 'true' for yes, or 'false' for no");
            string dui = Console.ReadLine();
            bool applicant_dui = Convert.ToBoolean(dui);
            

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int applicant_tickets = Convert.ToInt32(tickets);

           bool eligible = false;

            if (applicant_age > 15 && applicant_dui == false && applicant_tickets < 4)
            {
                eligible = true;
            }
            else
            {
                eligible = false; 
            }
           
            Console.WriteLine("Are you eligable for insurance: " + eligible);

            Console.ReadLine();
        }
    }
}
