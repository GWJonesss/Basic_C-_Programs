using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLING_METHODS
{
    class Program
    {
        public int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number to compute:");
            var Value = Convert.ToInt32(Console.ReadLine());

            var operatorObject = new Math();
            var result = operatorObject.Add(Value, 14);
            Console.WriteLine("First result is " + result);
            result = operatorObject.Sub(result, 3);
            Console.WriteLine("The second result is " + result);
            result = operatorObject.Div(result, 2);

            Console.WriteLine("The final result is " + result);
            Console.ReadLine();
        }
    }
}