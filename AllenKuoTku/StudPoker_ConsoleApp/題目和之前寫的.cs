using StudPoker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 請把它弄亂順序_並傳回前五張牌
{
    internal class 題目和之前寫的
    {
        //    將目前有寫好的功能, 改用物件的觀念來寫
        //enum Suit { } // 四個花色

        //enum Rank { } // 13個值,例如 1=Ace,2=Two,....13=King

        //class Card { } // 一張撲克牌,內含Suit, Rank properties

        //class Deck
        //{ // 一副撲克牌, 內含52張不同的撲克牌
        //    public Deck Shuffling() // 洗牌
        //         public Card Deal() // 向Deck索取下一張牌, 如果被取光了,丟出例外
        //         public Card Deal(int count) // 向Deck索取下 N 張牌, 如果剩下的牌不夠 N 張, 丟出例外
        //        }

        //class FiveCardStud
        //{ // 梭哈遊戲, 內含五張不同的撲克牌
        //  // ref https://www.newton.com.tw/wiki/%E6%A2%AD%E5%93%88
        //  // 寫出10支method,判斷手上的牌是不是同花順, 一對...., 盡量用 LINQ的技巧完成
        //    public bool IsRoyalFlush()
        //         public bool IsStraightFlush()
        //         public bool IsFullhouse()
        //         // ....
        //}
    }
    internal class 之前寫的
    {

        // 弄亂傳回其中隨機五張，不能重複。
        
        //int countOfCard = 5;

        //int n = allCards.Count;
        //var rng = new Random();
        //while (n > 1)
        //{
        //    n--;
        //    int k = rng.Next(n + 1);
        //        var value = allCards[k];
        //        allCards[k] = allCards[n];
        //    allCards[n] = value;
        //}

        //    var selectedCards = allCards.Take(countOfCard);

        //// 顯示選擇的卡
        ///
        //foreach (string card in selectedCards)
        //{
        //    Console.WriteLine(card);
        //}
        //Console.ReadLine();
        // See https://aka.ms/new-console-template for more information



    }
    public class 之前寫的2
    {
       //using System;
       // using System.Diagnostics;
       // using System.Reflection;

       // string[] suits = new string[] { "S", "H", "D", "C" };
       //     int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
       //     // todo 請顯示52張撲克牌內容,例如
       //     // S1, S2,..S13, H1,H2....
       //     //string result = string.Empty;


       //     // 自己亂寫
       //     //var linq = from s in suits.Select((ss, index) => new { index, ss })
       //     //           join v in values.Select((vv, index) => new { index, vv })
       //     //           on s.index equals v.index
       //     //           select s;
       //     //select new {
       //     //    result = $"{s.ss}+{v.vv}"
       //     //};

       //     // google查到https://linqsamples.com/linq-to-objects/projection/SelectMany
       //     var linq = suits.SelectMany(s => values, (s, a) => new {
       //         crossjoin = s + a
       //     });


       //         foreach (var item in linq.ToList())
       //         {
       //             //Console.WriteLine(item.suits + item.values);
       //             //Console.WriteLine(item.crossjoin);
       //         }
       // //Console.ReadLine();


       // suits.Join(values, _ => 1, _ => 1, (s, v) => $"{s}{v,2}").ToList().ForEach(Console.WriteLine);
    }
}
