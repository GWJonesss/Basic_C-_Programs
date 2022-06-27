using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA_SUBMISSION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------\nSTEP 1\n-----------------\n ");
            /////////////////////////////////////////////////
            //STEP 1 create a list of at least 10 employees//
            //////(At least two employees fname "Joe")///////
            /////////////////////////////////////////////////
            List<Employee> Employees = new List<Employee>();
            List<string> firstnames = new List<string>()
            {
                 "Ann", "Joe", "Noah", "Bob",  "Kate", "Joe", "Olivia", "Emma", "Jeff", "Dale"
            };

            List<string> lastnames = new List<string>()
            {
                "Jackson", "Garcia", "Turner", "Johnson", "Williams", "Brown", "Jones", "Davis", "Smith", "Miller"
            };

            List<int> IDs = new List<int>()
            {
                1,  2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            int i = 0;
            foreach (var firstName in firstnames)
            {
                Employees.Add(new Employee(firstName, lastnames[i], IDs[i]));
                i++;
            }

            foreach (Employee Employee in Employees)
            {   
                Console.WriteLine(Employee.firstname + " " + Employee.lastname + " " + Employee.ID);
            }


            Console.WriteLine("\n-----------------\nSTEP 2\n-----------------\n ");
            ///////////////////////////////
            //STEP 2 Using a foreach loop//
            ///////////////////////////////
            List<Employee> isJoe = new List<Employee>();
            
            foreach (Employee Employee in Employees)
            {
                if (Employee.firstname == "Joe")
                {

                    isJoe.Add(new Employee(Employee.firstname, Employee.lastname, Employee.ID));
                    
                }
            }
            foreach (Employee Employee in isJoe)
            {
                Console.WriteLine(Employee.firstname + " " + Employee.lastname + " " + Employee.ID);
            }

            Console.WriteLine("\n-----------------\nSTEP 3\n-----------------\n ");

            ///////////////////////////////////////
            //STEP 3 "" Using a lambda expression//
            ///////////////////////////////////////

            List<Employee> newIsJoe = Employees.Where(c => c.firstname == "Joe").ToList();
            foreach (Employee Employee in newIsJoe)
            {
                Console.WriteLine(Employee.firstname + " " + Employee.lastname + " " + Employee.ID);
            }

            Console.WriteLine("\n-----------------\nSTEP 4\n-----------------\n ");

            ////////////////////////////////////////////////////
            //STEP 4 list of  employees with an Id number > 5.//
            ////////////////////////////////////////////////////

            List<Employee> IdOver5 = Employees.Where(c => c.ID > 5).ToList();
            foreach (Employee Employee in IdOver5)
            {
                Console.WriteLine(Employee.firstname + " " + Employee.lastname + " " + Employee.ID);
            }
            Console.ReadLine();

        }
    }
}
