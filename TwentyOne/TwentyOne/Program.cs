using System;
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

            //int count = deck.Cards.Count(x => x.Face == Face.Ace);

            //List<Card> newlist = deck.Cards.Where(x => x.Face == Face.King).ToList();
            //foreach (Card card in newlist)
            //{
            //    Console.WriteLine(card.Face);
            //}


            List <int> numberlist = new List<int>() { 1, 2, 3, 535, 342, 23 };
            int sum2 = numberlist.Where(x => x > 20).Sum();
            int sum = numberlist.Sum(x => x+5);
            int max = numberlist.Max();
            Console.WriteLine(sum);
            Console.WriteLine(max);
            Console.WriteLine(sum2);


            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //   Console.WriteLine(card.Face + " of " + card.Suit);

            //}
            //Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
          

        }

    }
}
