using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPERATORS_SUBMISSION
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.FirstName = "John";
            employee.LastName = "Doe";
            employee.ID = 24923;

            Employee employee2 = new Employee();
            employee2.FirstName = "Richard";
            employee2.LastName = "Roe";
            employee2.ID = 25667;

            Console.WriteLine(employee.ID == employee2.ID);

            Console.ReadLine();
        }
    }
}
