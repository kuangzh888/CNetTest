using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20260331
{
    internal class Card
    {
        // suit: 花色
        public string suit;
        // rank: 点数
        public int rank;

        public Card(string suit, int rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public override string? ToString()
        {

            string new_rank = this.rank + "";

            switch (this.rank)
            {
                case 1:
                    new_rank = "A";
                    break;
                case 11:
                    new_rank = "J";
                    break;
                case 12:
                    new_rank = "Q";
                    break;
                case 13:
                    new_rank = "K";
                    break;
                default:
                    new_rank = this.rank.ToString();
                    break;
            }
            return this.suit + new_rank;
        }


        static void Main(string[] args)
        {
            Card card = new Card("红桃", 5);
            Console.WriteLine(card);
        }



    }
}
