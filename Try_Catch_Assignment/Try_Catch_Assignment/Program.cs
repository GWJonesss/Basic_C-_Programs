using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            Console.WriteLine("please type a number");
            int num = Convert.ToInt32(Console.ReadLine());
            try
            {
                foreach (int score in testScores)
                {
                    Console.WriteLine(score / num);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("please type a whole number");
                Console.ReadLine();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("please type a non-zero, positive number" );
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

            finally
            {
                Console.WriteLine("the end");
                Console.ReadLine();
            }
            

        }
    }
}
