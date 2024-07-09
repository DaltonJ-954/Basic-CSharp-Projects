using System;
using System.Collections.Generic;
using System.Text;
using LinkedList;

namespace DataStructures_Algorithms.LinkedList
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void InsertFirst(int data)
        {
            // Create a new node
            Node newNode = new Node();
            // Put the data in the node
            newNode.Data = data;
            // Put the old node in the next
            newNode.Next = First;
            // Make the first node the new node
            First = newNode;
        }

        public Node DeleteFirst()
        {
            // Assign the temporary variable
            Node temp = First;
            // Assign the next node
            First = First.Next;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("Iterating through list...");
            Node current = First;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }

        public void InsertLast(int data)
        {
            Node current = First;
            while (current != null)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;

            Console.ReadKey();
        }
    }
}
