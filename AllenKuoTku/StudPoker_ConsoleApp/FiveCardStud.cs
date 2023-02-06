using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudPoker
{
    //class FiveCardStud
    //{ // 梭哈遊戲, 內含五張不同的撲克牌
    //  // ref https://www.newton.com.tw/wiki/%E6%A2%AD%E5%93%88
    //  // 寫出10支method,判斷手上的牌是不是同花順, 一對...., 盡量用 LINQ的技巧完成
    //    public bool IsRoyalFlush()
    //         public bool IsStraightFlush()
    //         public bool IsFullhouse()
    //         // ....
    //}
    public class FiveCardStud
    {
        // UserCard是手上持有的卡牌
        public List<Card> UserCard{
            get
            {
                return UserCard;
            }
            private set
            {
                // UserCard屬性最多只能有五張
                if (value.Count <= 5)
                {
                    UserCard = value;
                }
            }
        }

        public bool IsRoyalFlush(List<Card> UserCard)
        {
            // 判斷手上的牌是不是同花大順，盡量用 LINQ的技巧完成
            // 1. 全部都是同一種花色
            bool flag = UserCard.All(x => x.Suit == UserCard[0].Suit);
            // 2. 10, J, Q, K, A
            bool flag2 = UserCard.All(x => x.Rank == Rank.Ten || x.Rank == Rank.Jack || x.Rank == Rank.Queen || x.Rank == Rank.King || x.Rank == Rank.Ace);
            // 3. 連續的數字
            bool flag3 = UserCard.All(x => x.Rank == UserCard[0].Rank + 1);
            // 4. 不能有重複的牌
            bool flag4 = UserCard.Distinct().Count() == 5;
            // 5. 不能有大小王
            //bool flag5 = UserCard.All(x => x.Rank != Rank.Ace || x.Rank != Rank.Two);
            return flag && flag2 && flag3 && flag4;
        }
        public bool IsStraightFlush(List<Card> UserCard)
        {
            // 判斷手上的牌是不是同花順，盡量用 LINQ的技巧完成
            // 1. 全部都是同一種花色
            bool flag = UserCard.All(x => x.Suit == UserCard[0].Suit);
            // 2. 連續的數字
            bool flag2 = UserCard.All(x => x.Rank == UserCard[0].Rank + 1);
            // 3. 不能有重複的牌
            bool flag3 = UserCard.Distinct().Count() == 5;
            // 4. 不能有大小王
            //bool flag4 = UserCard.All(x => x.Rank != Rank.Ace || x.Rank != Rank.Two);
            return flag && flag2 && flag3;
        }
        public bool IsFourOfAKind(List<Card> UserCard) 
        {
            // 判斷手上的牌是不是四條，盡量用 LINQ的技巧完成
            // 1. 至少四張牌都是同一種花色
            // 2. 至少四張牌都是同一種數字

            return false;
        }

    }
}
