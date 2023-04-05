using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 群聯3題
{
    struct ListStruct
    {
        public uint DataH;
        public uint DataL;
        public uint NextPtr;
    };



    public class sol
    {
        public void sol_1(int[] a, int size)
        {
            int j = 0;
            for (int i = 0; i <= 500; i++)
            {
                if (j < size && i == a[j])
                {
                    j++;
                }
                else
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
        /// <summary>
        /// // Q2
                /*給一個int a[20]已排序的陣列，請寫一個function(a, size, b) 能依照參數b(b = 0~4)別印出該區間的數字，
                  且不包含a陣列內的元素，例如 b =0, 印出0~99 b = 1, 印出100~199 */
        /// </summary>
        /// <param name="aa"></param>
        /// <param name="length"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void sol_2(int[] a, int size, int b)
        {
            if (b < 0) return;
            int min = 100 * b;
            int max = 100 * (b + 1) - 1;
            for (int i = min; i <= max; i++)
            {
                if (a.Contains(i)) {
                    continue;
                }
                else
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

    }
}
