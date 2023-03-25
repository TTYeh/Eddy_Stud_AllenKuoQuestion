// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics;
using System.Reflection;

string[] suits = new string[] { "S", "H", "D", "C" };
int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
// todo 請顯示52張撲克牌內容,例如
// S1, S2,..S13, H1,H2....
//string result = string.Empty;


// 自己亂寫
//var linq = from s in suits.Select((ss, index) => new { index, ss })
//           join v in values.Select((vv, index) => new { index, vv })
//           on s.index equals v.index
//           select s;
//select new {
//    result = $"{s.ss}+{v.vv}"
//};

// google查到https://linqsamples.com/linq-to-objects/projection/SelectMany
var linq = suits.SelectMany(s => values, (s, a) => new {
    crossjoin = s + a
});


foreach (var item in linq.ToList())
{
    //Console.WriteLine(item.suits + item.values);
    //Console.WriteLine(item.crossjoin);
}
//Console.ReadLine();


suits.Join(values, _ => 1, _ => 1, (s, v) => $"{s}{v,2}").ToList().ForEach(Console.WriteLine);