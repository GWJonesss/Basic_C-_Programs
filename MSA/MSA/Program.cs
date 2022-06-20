using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSA
{
    class Program
    {
        static void Main(string[] args)

        {
            var operatorObject = new My_Class();


            Console.WriteLine("Please input a number");
            int fstChoice = Convert.ToInt32(Console.ReadLine());

           
            Console.WriteLine("Optional input a second number");
            try
            {
                int sndChoice = Convert.ToInt32(Console.ReadLine());

                var result = operatorObject.Add(fstChoice, sndChoice);

                Console.WriteLine("The result of the calculations is: " + result);

                Console.ReadLine();

            }
            catch
            {
                

                var result = operatorObject.Add(fstChoice);

                Console.WriteLine("The result of the calculations is: " + result);

                Console.ReadLine();
            }



        }
    }
}
