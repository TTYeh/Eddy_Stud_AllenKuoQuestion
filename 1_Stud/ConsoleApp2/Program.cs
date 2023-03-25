// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System;
using static System.Net.Mime.MediaTypeNames;


List<int> aaa = new List<int>() { 1, 2, 4 };
List<int> bbb = new List<int>() { 1, 3, 4 };

ListNode list1_3 = new ListNode(4);
ListNode list1_2 = new ListNode(2, list1_3);
ListNode list1 = new ListNode( 1 , list1_2);
List<string> MyCard = new List<string>() { };

ListNode list2_3 = new ListNode(4);
ListNode list2_2 = new ListNode(3, list2_3);
ListNode list2 = new ListNode(1, list2_2);

var a = new Solution();
Console.WriteLine(a.MergeTwoLists(list1, list2));
Console.ReadLine();

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        return new ListNode();
    }
}


public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}