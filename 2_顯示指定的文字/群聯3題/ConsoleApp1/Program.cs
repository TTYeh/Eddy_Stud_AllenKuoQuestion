using System;

struct ListStruct
{
    public uint DataH;
    public uint DataL;
    public uint NextPtr;
};

class Program
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
