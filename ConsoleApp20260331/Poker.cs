using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20260331
{
    internal class Poker
    {

        public Card[] cards = new Card[52];
        public string[] suits = new string[] { "红桃", "黑桃", "梅花", "方块" };


        public Poker()
        {
            for (int i = 0; i < suits.Length; i++)
            {
                for (int rank = 1; rank < 14; rank++)
                {
                    Card card = new Card(suits[i], rank);
                    cards[i * 13 + (rank - 1)] = card;
                }
            }
            
        }


        void OutPut()
        {
            for (int i = 0; i < cards.Length; i++)
            {
                Console.Write(cards[i] + " ");
                if ((i + 1) % 13 == 0)
                {
                    Console.WriteLine("");
                }
            }
        }


        public void Shuffle()
        {
            Console.WriteLine("洗牌：");
            Random random = new Random();
            for (int i = cards.Length; i > 0; i--)
            {
                Card tmp = cards[i - 1];
                Console.WriteLine(tmp);
            }
        }



        static void Main(string[] args)
        {
            Poker po = new Poker();
            po.OutPut();

            //po.Shuffle();
        }




    }
}
