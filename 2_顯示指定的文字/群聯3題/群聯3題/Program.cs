// See https://aka.ms/new-console-template for more information
// Q1
/* 給一個int a[20]已排序的陣列，請寫一個function(a, size)能印出0~500的數字，
   且不包含a陣列內的元素，請用最少的時間和空間複雜度完成 */
using 群聯3題;

Console.WriteLine("----第1題----");
//int[] a = new int[] { 1, 2, 3 };
sol solution = new sol();
//solution.sol_1(a, a.Length);


// Q2
/*給一個int a[20]已排序的陣列，請寫一個function(a, size, b) 能依照參數b(b = 0~4)別印出該區間的數字，
  且不包含a陣列內的元素，例如 b =0, 印出0~99 b = 1, 印出100~199 */
Console.WriteLine("----第2題----");
int[] aa = new int[] { 1, 2, 3, 101 };
int bb = 1;
solution.sol_2(aa, aa.Length, bb);
















