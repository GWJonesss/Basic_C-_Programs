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


        //PICK CLASS
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
        //END CLASS PICK
        

        //PICK STRENGTH AND DEXTERITY
        Console.WriteLine("Choose your Strength Level (your choice will inversely effect your Dexterity Level) ");
        Console.WriteLine("*ENTER NUMBER BETWEEN 1-6 TO INDICATE CHOICE*");
        int sChoice = Convert.ToInt32(Console.ReadLine());
        int[] strengthLvl = { 1, 2, 3, 4, 5, 6 };

        while (sChoice > 6 || sChoice < 1)
        {
            Console.WriteLine("OPS THAT WASN'T AN OPTION... *ENTER NUMBER BETWEEN 1-6 TO INDICATE CHOICE*");
            sChoice = Convert.ToInt32(Console.ReadLine());

        }
        //END ST. AND IN. PICK


        //PICK AGE
        Console.WriteLine("Choose your Age (the younger you are the more health you have, \nbut the older you are the more intelligence you have) ");
        Console.WriteLine("1: Young" + "\n2: Middle Aged" + "\n3: Elder");
        Console.WriteLine("*ENTER NUMBER BETWEEN 1-3 TO INDICATE CHOICE*");
        int aChoice = Convert.ToInt32(Console.ReadLine());
        

        while (aChoice > 3 || aChoice < 1)
        {
            Console.WriteLine("OPS THAT WASN'T AN OPTION... *ENTER NUMBER BETWEEN 1-3 TO INDICATE CHOICE*");
            aChoice = Convert.ToInt32(Console.ReadLine());

        }



        List<string> ageList = new List<string>();
        ageList.Add("Young");
        ageList.Add("Middle Aged");
        ageList.Add("Elder");








        int A = aChoice - 1;

        int X = cChoice - 1;

        int Y = sChoice - 1;

        int D = 7 - sChoice;

        int H = 20 - (2 * aChoice);

        int I = 7 + (3 * aChoice);

        Console.WriteLine("\n" + "Your Character is a: " + ageList[A]+ " " +classType[X] + "\nWith a Strength Level of: " 
            +strengthLvl[Y] + "\nAnd an Dexterity Level of: " + D);
        Console.WriteLine("\nBecause of your age,\nYour Health Level is set to: " + H + 
            "\nAnd Your Intelligence Level is: " + I);



        Console.ReadLine();
    }
    }

