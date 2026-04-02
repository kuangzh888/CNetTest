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

        public void Suffle()
        {
            Random random = new Random();
            for (int i = 0; i < this.cards.Length; i++)
            {
                int index = random.Next(this.cards.Length);
                (this.cards[i], this.cards[index]) = (this.cards[index], this.cards[i]);
            }
        }

        public List<Card> GetOneHand()
        {
            List<Card> list = new List<Card>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(this.cards[i]);
            }
            return list;
        }


        public string GetType(List<Card> hand)
        {
            hand.Sort((a, b) => a.rank.CompareTo(b.rank));

            foreach (Card card in hand)
            {
                Console.Write(card + " ");
            }
            HashSet<string> suitSet = hand.Select(x => x.suit).ToHashSet();
            HashSet<int> rankSet = hand.Select(x => x.rank).ToHashSet();

            //HashSet<string> suitSet = new HashSet<string>();
            //foreach (Card card in hand)
            //{
            //    suitSet.Add(card.suit);
            //}
            //HashSet<int> rankSet = new HashSet<int>();
            //foreach (Card card in hand)
            //{
            //    rankSet.Add(card.rank);
            //}

            bool isStraight = hand[4].rank - hand[0].rank == 4 && rankSet.Count == 5;

            if (suitSet.Count == 1 && isStraight)
            {
                return "同花顺";
            }
            
            if (suitSet.Count == 1)
            {
                return "同花";
            }
            
            if (isStraight)
            {
                return "顺子";
            }

            if (rankSet.Count == 4)
            {
                return "一对";
            }

            if (rankSet.Count == 2)
            {

                Dictionary<int, int> rankCount = new Dictionary<int, int>();
                foreach (Card card in hand)
                {
                    if (rankCount.ContainsKey(card.rank))
                    {
                        rankCount[card.rank]++;
                    } else
                    {
                        rankCount[card.rank] = 1;
                    }
                }

                if (rankCount.ContainsValue(4))
                {
                    return "四条";
                } else
                {
                    return "满堂红";
                }
            }

            if (rankSet.Count == 3)
            {
                Dictionary<int, int> rankCount = new Dictionary<int, int>();
                foreach (Card card in hand)
                {
                    if (rankCount.ContainsKey(card.rank))
                    {
                        rankCount[card.rank]++;
                    }
                    else
                    {
                        rankCount[card.rank] = 1;
                    }
                }

                if (rankCount.ContainsValue(3))
                {
                    return "三条";
                }
                else
                {
                    return "两对";
                }
            }
            return "无对";
        }



        static void Main(string[] args)
        {
            Poker po = new Poker();
            po.OutPut();
            Console.WriteLine("洗牌：");


            //foreach(Card card in hand)
            //{
            //    Console.Write(card + " ");
            //}

            // 测试同花顺
            //Card card1 = new Card("黑桃", 13);
            //Card card2 = new Card("黑桃", 12);
            //Card card3 = new Card("黑桃", 11);
            //Card card4 = new Card("黑桃", 10);
            //Card card5 = new Card("黑桃", 9);

            // 测试
            //Card card1 = new Card("红桃", 7);
            //Card card2 = new Card("黑桃", 2);
            //Card card3 = new Card("红桃", 1);
            //Card card4 = new Card("红桃", 2);
            //Card card5 = new Card("红桃", 10);
            //List<Card> temps = new List<Card> { card1, card2, card3, card4, card5 };


            for (int i = 0; i < 100; i++)
            {
                po.Suffle();
                Console.WriteLine("");
                Console.WriteLine(po.GetType(po.GetOneHand()));
            }
        }





    }
}
