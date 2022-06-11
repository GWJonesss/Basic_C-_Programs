using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_do_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guess My Favorite Number program");
            System.Threading.Thread.Sleep(500);

            Console.WriteLine("You get 3 guesses");
            var guess_Count = 0;
            System.Threading.Thread.Sleep(500);
            string win = ("Congratulations, you guessed the right number!");
            string between = ("Please guess number between 1 and 10:");
            int guesses_left = 3;
            Console.WriteLine(between);
            int v = Convert.ToInt32(Console.ReadLine());
            int guess = v;


            if (guess == 2) // if they guess 2 off the bat they win and it bypasses all the rest
            {
                Console.WriteLine(win);
            }


            while (guess != 2){ // loop for catch all if 2 not guesses on as first guess
                
                if (guess < 11 && guess > 0){
                    int i = guess_Count++; // add 1 to guess count each time a number between 1 and 10 are guessed
                    guesses_left--;// this way when a proper guess happens it updates guesses left for over future error guesses outside of the 1 to 10 range so player knows that error guess not counted against them
                    if (i == 2)    
                    {
                        Console.WriteLine("You Lost!"); // when you run out of guesses you loose
                        break;
                    }
                        Console.WriteLine("You guessed the wrong number, please guess again:"); // prompt to guess again if guess was inside the 1 to 10 range but not 2

                        do// forces hints to insert for every proper guess, regular while loop doesn't work here
                        {
                        if (guess > 2)
                        {
                            Console.WriteLine("*Hint* You Guessed to high"); // if guess is proper it will give a hint if it is to high
                        }
                        else
                        {
                            Console.WriteLine("*Hint* You Guessed to low"); // if guess is lower than 2 it will give hint that guess was to low
                        }
                         
                        } while (guess < 2 && guess > 1  && guess < 11 && guess > 0 && i != 2); // confines hints to guesses inside of 1-10 range and stops hints if game is lost


                        int x = Convert.ToInt32(Console.ReadLine());// updates guesses after first proper guess within range
                        guess = x;

                            if (guess > 10 || guess < 1)// if guess outside of range after a proper guess was given
                            {
                                    Console.WriteLine("you have: " + guesses_left + " guesses left. " + between);
                                    guess = Convert.ToInt32(Console.ReadLine());

                                    if (guess == 2)
                                    {
                                        Console.WriteLine(win);
                                    }

                            }

                            if (guess == 2) //guesses after 1st guess can win if they are 2
                            {
                            Console.WriteLine(win);
                            }
                }

                else if (guess > 10 || guess < 1)// sets up response to gusses outside of 1-10 range till a proper guess is made
                {

                                    Console.WriteLine("you have: " + guesses_left + " guesses left. " + between);
                                    guess = Convert.ToInt32(Console.ReadLine());

                                    if (guess == 2) // fixes bug when 2 is guessed after an error guess, when a proper guess has yet to be entered during game
                                    {
                                        Console.WriteLine(win);
                                    }

                }



            }

            Console.ReadLine();

        }
    }
}
    
