using System;
using System.Collections.Generic;

namespace CONSOLE_APP_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //STEP 1

            string[] stringArray = { "apples", "bananas", "grapes", "pears" };

            Console.WriteLine("Enter an adjective that describes fruit");
            string adj = (Console.ReadLine());

            for (int j = 0; j < stringArray.Length; j++)
            {

                {
                    Console.WriteLine(adj + " " + stringArray[j]);

                }
            }


            //STEP 2
            for (int a = 0; a < 5; a++)
            {
                Console.WriteLine("I fixed the infinite loop" + adj);
            }


            //STEP 3
            for (int b = 0; b < 3; b++)
            {
                Console.WriteLine("the comparison that’s used to determine whether to continue iterating the loop is a  '<'" + adj);
            }

            for (int c = 0; c <= 6; c++)
            {
                Console.WriteLine("the comparison that’s used to determine whether to continue iterating the loop is a  '<='" + adj);
            }


            //STEP 4
            string[] stringArray2 = { "apple", "banana", "grape", "pear" };

            Console.WriteLine("guess a type of fruit to see if it is in the secret list, please use only lower case");
            string guess = (Console.ReadLine());

            for (int j = 0; j < stringArray2.Length; j++)
            {
                if (stringArray2[j] == guess)
                {
                    Console.WriteLine("Yes, your guess of " + stringArray2[j] + " is in the list!");
                    break;
                }
                else
                {
                    Console.WriteLine("Your guess " + "'" + guess + "'" + " is not in the secret list");
                    Console.WriteLine("*HINT* make sure your guess is singular and in lowercase");

                    Console.WriteLine("Please guess again");
                    guess = (Console.ReadLine());

                    if (stringArray2[j] == guess)
                    {
                        Console.WriteLine("Yes, your guess of " + stringArray2[j] + " is in the list!");
                        break;
                    }

                }
            }


            //STEP 5

            List<string> animals = new List<string>() { "bird", "cat", "dog", "snake", "bird", "cat", "bird" };

            Console.WriteLine("guess a type of animal, make sure you use all lowercase");
            string aGuess = (Console.ReadLine());

            bool matchExists = false;

            for (int ani = 0; ani < animals.Count; ani++)
            {
                if (animals[ani] == aGuess)
                {
                    matchExists = true;
                    Console.WriteLine(ani + aGuess);
                }
                if (matchExists == false)
                {
                    Console.WriteLine("Sorry, this is not in the list");
                    
                }
            }




            //STEP 6



            List<string> names2 = new List<string>() { "Jack", "Jack", "Jake", "John", "Jack", "John", "Jeremy", "Jack" };
            List<string> repeat = new List<string>();
            bool matchExists2 = false;
            int count2 = 0;


            //FOR EACH HERE
            foreach (string name in names2)
            {
                Console.WriteLine("-------------------- \n" + name);
                for (int nam = 0; nam < repeat.Count; nam++)
                {
                    
                    if (repeat[nam] == name)
                    {
                        matchExists2 = true;

                        Console.WriteLine(" *this has already shown up in the list* ");
                        break;
                        
                    }

                    
                }
                
                repeat.Add(name);




            }




            Console.ReadLine();

        }
    }
}
