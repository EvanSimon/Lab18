using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodePractice
{
    class Node
    {
        public string Data
        {
            set; get;
        }
        public Node Next { set; get; }
        public Node Previous { set; get; }
    }

    class DoublyLinkedNode
    {

    }
    class LinkedListNode
    {
        public Node Head { set; get; }
        public Node Tail { set; get; }
        public int Count { set; get; }

        public void Add(string userInput)
        {
            Node newNode = new Node { Next = null, Data = userInput };
            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
                Count++;
            }
            else
            {
                //change the previous reference in the new node
                newNode.Previous = Tail;
                //change the tail next reference
                Tail.Next = newNode;
                //change the tail
                Tail = newNode;
                Count++;
            }
        }
        public Node GetNode(int index)
        {
            int start = 0;
            Node temp = Head;   //mark the start of my search
            while (start != index)
            {
                start += 1;
                temp = temp.Next;
            }
            return temp;    //once found; return the node; else return null
        }
        public void PrintList()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(GetNode(i).Data);
            }
        }
    }

}