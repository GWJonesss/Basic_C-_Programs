using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAIN_METHOD
{
    class Program
    {
        static void Main(string[] args)
        {
            var Value = 5;

            var operatorObject = new Math();
            int result = operatorObject.Add(Value, 14);

            Console.WriteLine("The result of 5 + 14 is " + result);

            decimal Value2 = 5.5m;
            int result2 = operatorObject.Add(Value2, 3);
            Console.WriteLine("The result of 5.5 + 3 returned as an int is " + result2);

            string Value3 = "24";
            int result3 = operatorObject.Add(Value3, 2);

            Console.WriteLine("The result of '24' + 2 returned as an int is " + result3);
            Console.ReadLine();
        }
    }
}
