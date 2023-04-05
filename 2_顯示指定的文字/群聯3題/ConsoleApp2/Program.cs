using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /*給予一個 structure 
struct ListStruct{
    unsigned int DataH;
    unsigned int DataL;
    unsigned int NextPtr;
};
struct ListStruct ListArray[1000];
#define NULL 0xFFFF
unsigned int ListHead = 0;
其中有兩個條件
條件一  ListArray[Entry1].NextPtr = ListArray[Entry2] 
條件二  (ListArray[Entry2].DataH << 16 + ListArray[Entry2].DataL) > (ListArray[Entry1].DataH << 16 + ListArray[Entry1].DataL)
==> 第一個 index 中的 NextPtr 會指到另一個 index 中的起始位址 
    另一個 index 中的起始位址的資料內容大小一定大於原起始資料的大小
請寫一個function(unsigned int DATA_A, unsigned int DATA_B)，
能在ListArray中找到符合ListArray[Entry].DataH == Data_A 且 ListArray[Entry].DataL == Data_B
並印出其結果。如果沒有找到的話，印出”no found"  */
    struct ListStruct
    {
        public uint DataH;
        public uint DataL;
        public uint NextPtr;
    };



    internal class Program
    {
        static ListStruct[] ListArray = new ListStruct[1000];
        static uint NULL = 0xFFFF;
        static uint ListHead = 0;

        static void Main(string[] args)
        {
            // 初始化 ListArray 和條件
            for (int i = 0; i < 1000; i++)
            {
                ListArray[i] = new ListStruct
                {
                    DataH = (uint)i,
                    DataL = (uint)i,
                    NextPtr = NULL
                };
            }
            ListArray[1].DataH = 10;
            ListArray[1].DataL = 10;
            ListArray[1].NextPtr = 2;
            ListArray[2].DataH = 20;
            ListArray[2].DataL = 20;

            // 呼叫function查找符合條件的ListStruct
            FindListStruct(10, 10);
            FindListStruct(99, 99);

            Console.ReadLine();
        }

        static void FindListStruct(uint Data_A, uint Data_B)
        {
            uint Entry = ListHead;
            while (Entry != NULL)
            {
                if (ListArray[Entry].DataH == Data_A && ListArray[Entry].DataL == Data_B)
                {
                    Console.WriteLine($"Found ListStruct at index {Entry}");
                    return;
                }
                Entry = ListArray[Entry].NextPtr;
            }
            Console.WriteLine("no found");
        }
    }

}
