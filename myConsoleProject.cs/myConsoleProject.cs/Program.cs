using System;


namespace myConsoleProject.cs
{
    internal class Program
    {
        static void Main()
        {

            

            Console.WriteLine("The Tech Academy");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Student Daily Report");

            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string p_Num = Console.ReadLine();
            int page_Number = Convert.ToInt32(p_Num);

            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            string help_Needed = Console.ReadLine();
            bool help = Convert.ToBoolean(help_Needed);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string pos_Exp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hrs = Console.ReadLine();
            int study_Hours = Convert.ToInt32(hrs);


            Console.WriteLine("Thank you " + name + '\n'+ 
                "for your answers" + '\n' + "- - - - - - - - -" + '\n' +
                "What course are you on? :" + course + '\n' +
                "What page number? :" + page_Number + '\n' +
                "Do you need help with anything? Please answer “true” or “false.” :" + help + '\n' +
                "Were there any positive experiences you’d like to share? Please give specifics. :" + pos_Exp + '\n' +
                "Is there any other feedback you’d like to provide? Please be specific.” :" + feedback + '\n' +
                "How many hours did you study today? :" + study_Hours + '\n' +
                "- - - - - - - - -" + '\n' +
                ". An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }  
    }
}
