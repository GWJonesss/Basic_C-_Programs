﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            //Console.WriteLine(underlyingValue);

            
            
            
            
            //game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            //game.ListPlayers();
            //Console.ReadLine();
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>();
            //Player player = new Player();
            //player.Name = "Jesse";
            //game +=  player;
            //game -=  player;



            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
               Console.WriteLine(card.Face + " of " + card.Suit);

            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
          

        }

    }
}
