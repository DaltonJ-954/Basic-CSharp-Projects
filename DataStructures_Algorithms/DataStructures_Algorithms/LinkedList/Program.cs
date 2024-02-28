using System;
using DataStructures_Algorithms.LinkedList;

namespace DataStructures_Algorithms.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.InsertFirst(1);
            linkedList.InsertFirst(2);
            linkedList.InsertFirst(3);
            linkedList.InsertFirst(4);

            linkedList.DeleteFirst();
            linkedList.DeleteFirst();

            linkedList.InsertLast(542);
            linkedList.InsertLast(178);

            linkedList.DisplayList();
        }
    }
}
