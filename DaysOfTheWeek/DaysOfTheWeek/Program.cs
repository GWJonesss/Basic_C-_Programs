using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To the Day Of The Week App!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Please enter what day it is today... (ex 'Monday')");
            string dayAnswer = (Console.ReadLine());

            
            try
            {
                Day day = (Day)Enum.Parse(typeof(Day), dayAnswer);
                if (Enum.IsDefined(typeof(Day), day))
                {
                    Console.WriteLine("Good job!");
                    Console.ReadLine();
                }

            }
            
            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.ReadLine();
            }
        }
            
            
    }
}
