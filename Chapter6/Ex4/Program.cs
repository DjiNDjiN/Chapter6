using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = new string[4] { "Spades", "Diamonds", "Hearts", "Clubs" };
            string[] cards = new string[13] { "Ace of", "Two of", "Three of", "Four of", "Five of", "Six of", "Seven of", "Eight of", "Nine of", "Ten of", "Jack of", "Queen of", "King of" };

            for (int color = 0; color < 4; color++)
            {
                for (int card = 0; card < 13; card++)
                {
                    Console.WriteLine(colors[color] + " " + cards[card]);
                }
            }
            
        }

    }
}
