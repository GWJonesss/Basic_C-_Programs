using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS_Assignment
{
    public class Employee : Person , IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: ");
            base.SayName();

        }
        public void Quit()
        {
            Console.WriteLine("this is the 'Quit' method \n");
        }
    }
}
