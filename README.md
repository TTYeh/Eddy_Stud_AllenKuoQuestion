# AllenKuoQuestionBank互動解題

謝謝AllenKuo的code建議與題目
## 首頁
1. 記得計時

| 題目 | 解答 | 建議 |預估 |實際 |
| -------- | -------- | -------- |-------- |-------- |
| 1.組合撲克牌52張 | [連結](https://replit.com/@ttyeh/ForLoop2LayerPractice#main.cs)     | Text     |5min|6min|
| 2.組合撲克牌52張用LINQ | [連結](https://replit.com/@ttyeh/LinqCrossJoin2arraySource#main.cs)     | Text     |15min|24min|
| 3.承上，隨機取5張 | [連結](https://replit.com/@ttyeh/RandonSelectCards#main.cs)     | Text     |10min|8min|
| 4.承上，隨機取5張不重複 | [連結](https://replit.com/@ttyeh/Select5CardNotDuplicated#main.cs)     | Text     |x|x|
| 5.承上，洗亂順序再取前五張 | [連結](https://replit.com/@ttyeh/5ListRandonlized#main.cs)     | Text     |x|x|
| 6.請寫出梭哈遊戲 | [我的github](https://github.com/TTYeh/AllenKuoQuestionBank/tree/main/AllenKuoTku/StudPoker_ConsoleApp)     | Text     |8小時|x|

2/6花 1.5小時寫出同花順和定義基本class
題目6:
```
enum Suit{} // 四個花色

enum Rank{} // 13個值,例如 1=Ace,2=Two,....13=King

class Card{} // 一張撲克牌,內含Suit, Rank properties
  
class Deck{ // 一副撲克牌, 內含52張不同的撲克牌
 public Deck Shuffling() // 洗牌
 public Card Deal() // 向Deck索取下一張牌, 如果被取光了,丟出例外
 public Card Deal(int count) // 向Deck索取下 N 張牌, 如果剩下的牌不夠 N 張, 丟出例外
}

class FiveCardStud{ // 梭哈遊戲, 內含五張不同的撲克牌
 // ref https://www.newton.com.tw/wiki/%E6%A2%AD%E5%93%88
 // 寫出10支method,判斷手上的牌是不是同花順, 一對...., 盡量用 LINQ的技巧完成
 public bool IsRoyalFlush()
 public bool IsStraightFlush()
 public bool IsFullhouse()
 // ....
}
```

## CodeReview
### 原始題目數據
```csharp=
string[] suits = new string[] { "S", "H", "D", "C" };
int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
```
### 題1_CodeReview
```csharp=
string[] suits = new string[] { "S", "H", "D", "C" };
int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
// todo 請顯示52張撲克牌內容,例如
// S1, S2,..S13, H1,H2....
//string result = string.Empty;

題1
// 原本:
string[] MyCard = new string[52];
// 不要魔法數字:
int arrayLength = (suits.Length + 1) * (values.Length + 1) ;
string[] MyCard = new string[arrayLength];

// 如果寫成更好維護
MyCard[i++] = $"{str}{num}"
```


### 題2_CodeReview:神奇join
```csharp=
請看截圖老師的寫法
```
![](https://i.imgur.com/5tkiSAk.png)

### 題3:變數命名

```csharp=
你目前的寫法, 其實有機會讓五張牌裡,居然有重覆一張牌, 這是 bug

wantNum 變數名,不太好countOfCard = 5

Cards變數名稱小寫

```
### 題4:Linq 一行顯示
```csharp=
suits.Join(values, _ => 1, _ => 1, (s, v) => $"{s}{v,2}").ToList().ForEach(Console.WriteLine);

```
### 題5:洗牌的擴充方法

```csharp=
    public static class ListExtension
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

```
