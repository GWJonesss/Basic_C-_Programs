using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_S_A
{
    class Program
    {
        static class information
        {

            
            public static string info = " it must be a positive number";
            

           
            public static void details()
            {
                Console.WriteLine("Welcome to the Divider Program");
            }

        }
        static void Main(string[] args)
        {
            information.details();
            

            Console.WriteLine("Please enter a number");
            Console.WriteLine("Rules : {0} ", information.info);
            int Value = Convert.ToInt32(Console.ReadLine());

            New_Class num = new New_Class();

            

            int diff;
            bool greater = Compare(0, Value, out diff);

            if (greater)
            {
                Console.WriteLine(diff + " is not a positive number");


                Console.ReadLine();
            }
            else
            {
            num.div(Value);
            Console.ReadLine();
            }
            

        }

        static bool Compare (int a, int b, out int difference)
        {
            difference = a + b;
            return a > b;

        }
        static bool Compare (int a, int b)
        {
            
            return a > b;

        }
    }
    
}
