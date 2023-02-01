# AllenKuoQuestionBank互動解題
與AllenKuo老師練習題+CodeReview筆記
原本:https://hackmd.io/wuUmp8YpRC2tgp1drOwHPg?view
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

「
### 原始題目數據
```csharp=
string[] suits = new string[] { "S", "H", "D", "C" };
int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
```
### 題1
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


### 題2
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
![](https://i.imgur.com/5tkiSAk.png)

### 題3

```csharp=
你目前的寫法, 其實有機會讓五張牌裡,居然有重覆一張牌, 這是 bug

wantNum 變數名,不太好countOfCard = 5

Cards變數名稱小寫

```
