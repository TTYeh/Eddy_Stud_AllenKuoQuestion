// 得到52張牌
using System;
using System.Collections.Generic;

string[] suits = new string[] { "S", "H", "D", "C" };
int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
List<string> allCards = suits.Join(values, _ => 1, _ => 1, (s, v) => $"{s}{v,2}").ToList();
// 弄亂傳回其中隨機五張，不能重複。
int countOfCard = 5;

Random rnd = new Random();
string[] selectedCards = new string[countOfCard];
int allCardNum = allCards.Count();



for (int i = 0; i < countOfCard; i++)
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

// 顯示選擇的卡
foreach (string card in selectedCards)
{
    Console.WriteLine(card);
}
Console.ReadLine();
