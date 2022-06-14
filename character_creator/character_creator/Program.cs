using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class Program
    {
    static void Main()
    {


        Console.WriteLine("Welcome to Character Creater. Please follow the instructions below.");

        System.Threading.Thread.Sleep(1000);

        Console.WriteLine("Pick your class:" + "\n1: Barbarian" + "\n2: Bard" + "\n3: Cleric" + 
            "\n4: Druid"+ "\n5: Fighter" + "\n6: Monk" + "\n7: Paladin" + "\n8: Ranger");
        Console.WriteLine("*ENTER NUMBER BETWEEN 1-8 TO INDICATE CHOICE*");
        int cChoice = Convert.ToInt32(Console.ReadLine());


        while (cChoice > 8 || cChoice < 1)
        {
            Console.WriteLine("OPS THAT WASN'T AN OPTION... *ENTER NUMBER BETWEEN 1-8 TO INDICATE CHOICE*");
            cChoice = Convert.ToInt32(Console.ReadLine());

        }

        string[] classType = { "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger" };

        int X = cChoice - 1;


        Console.WriteLine("Choose your Strength Level (your choice will inversely effect your Intelligence Level) ");
        Console.WriteLine("*ENTER NUMBER BETWEEN 1-6 TO INDICATE CHOICE*");
        int sChoice = Convert.ToInt32(Console.ReadLine());
        int[] strengthLvl = { 1, 2, 3, 4, 5, 6 };

        while (sChoice > 6 || sChoice < 1)
        {
            Console.WriteLine("OPS THAT WASN'T AN OPTION... *ENTER NUMBER BETWEEN 1-6 TO INDICATE CHOICE*");
            sChoice = Convert.ToInt32(Console.ReadLine());

        }
        int Y = sChoice - 1;

        int i = 7 - sChoice;


        Console.WriteLine("\n" + "Your Character is a: " +classType[X] + "\nWith a Strength Level of: " 
            +strengthLvl[Y] + "\nAnd an Intelligence level of: " + i);
        Console.WriteLine();



        Console.ReadLine();
    }
    }

