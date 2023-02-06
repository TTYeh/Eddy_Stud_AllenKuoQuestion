using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StudPoker
{
    public class Deck
    {
        private List<Card> _cards = new List<Card>();
        public Deck()
        {
            // 一副撲克牌, 內含52張不同的撲克牌   
            var suits = Enum.GetValues(typeof(Suit)).Cast<Suit>();
            var rank = Enum.GetValues(typeof(Rank)).Cast<Rank>();
            _cards = suits.Join(rank, _ => 1, _ => 1, (s, v) => new Card(s,v){ }).ToList();
            //_cards = suits.Join(rank, _ => 1, _ => 1, (s, v) => new Card() { Suit = s, Rank = v }).ToList();
            //List<Card> _cards = suits.Join(rank, _ => 1, _ => 1, (s, v) => new Card() { Suit = s, Rank = v }).ToList();

            // 一副撲克牌, 內含52張不同的撲克牌(之前寫的)
            //string[] suits = new string[] { "S", "H", "D", "C" };
            //int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            //List<string> allCards = suits.Join(values, _ => 1, _ => 1, (s, v) => $"{s}{v,2}").ToList();
        }
        public Deck Shuffling() // 洗牌
        {
            _cards.Shuffle();
            return this;
        }
        public Card Deal() // 向Deck索取下一張牌, 如果被取光了,丟出例外
        {
            if (_cards.Count == 0)
            {
                throw new Exception("No more cards");
            }
            Card takeCard = _cards[0];
            _cards.RemoveAt(0);
            return takeCard;
        }
        public List<Card> Deal(int count) // 向Deck索取下 N 張牌, 如果剩下的牌不夠 N 張, 丟出例外
        {
            if (_cards.Count < count)
            {
                throw new Exception("No more cards");
            }
            List<Card> takeCards = _cards.Take(count).ToList();
            _cards.RemoveRange(0, count);
            return takeCards;
        }


        //class Deck
        //{ // 一副撲克牌, 內含52張不同的撲克牌
        //    public Deck Shuffling() // 洗牌
        //         public Card Deal() // 向Deck索取下一張牌, 如果被取光了,丟出例外
        //         public Card Deal(int count) // 向Deck索取下 N 張牌, 如果剩下的牌不夠 N 張, 丟出例外
        //        }
        //public Deck Shuffling(Deck MyDeck) // 洗牌
        //{
        //    MyDeck.Shuffle();

        //}
        //public Card Deal() // 向Deck索取下一張牌, 如果被取光了,丟出例外
        //public Card Deal(int count) // 向Deck索取下 N 張牌, 如果剩下的牌不夠 N 張, 丟出例外

    }
}
