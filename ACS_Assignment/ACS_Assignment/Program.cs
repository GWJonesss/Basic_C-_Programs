using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACS_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {


            IQuittable emp1 = new Employee();

            emp1.Quit();


            Employee employee = new Employee();

            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();

            
        }

    }
}
