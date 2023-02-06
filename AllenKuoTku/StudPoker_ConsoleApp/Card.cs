using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudPoker
{
    public enum Suit {
        Spade, //黑桃
        Heart, //紅心
        Diamond, //方塊
        Club //梅花
    }

    public enum Rank
    {
        Ace = 1, //A
        Two, //2
        Three, //3
        Four, //4
        Five, //5
        Six, //6
        Seven, //7
        Eight, //8
        Nine, //9
        Ten, //10
        Jack, //J
        Queen, //Q
        King //K
    }
    public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }
        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public Card GetCard()
        {
            return new Card(Suit, Rank);
        }

        public override string ToString()
        {
            return $"{Suit} {Rank}";
        }

    }
}
