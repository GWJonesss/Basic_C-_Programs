using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARAMETERS_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> things = new Employee<string>();
            things.Things = new List<string>() { "thing 1 ", "thing 2 ", "thing 3" };

            Employee<int> intss = new Employee<int>();
            intss.Things = new List<int>() {1,2,3 };

            foreach (var thing in things.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (var ints in intss.Things)
            {
                Console.WriteLine(ints);
            }



            Console.ReadLine();
            
            
        }
    }
}
