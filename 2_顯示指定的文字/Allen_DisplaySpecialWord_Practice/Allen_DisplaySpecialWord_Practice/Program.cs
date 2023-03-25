// See https://aka.ms/new-console-template for more information
using SolQuestionLib;
using System.Drawing;

SolQuestion2 Solution = new SolQuestion2();
Solution.CreatePoundSign(10); // 有測試-1, 11的邊界條件情況
string ans = Solution.DisplayString();
Console.WriteLine(ans);

//10:40 開始
//11:25 結束
//12:00 Debug完成