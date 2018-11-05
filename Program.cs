using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Node
    {
        public int Data
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

        public void Add(int userInput)
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

        public bool RemoveAt(int index)
        {
            if (index >= Count)
            {
                
                return true;
            }
            else
            {
                return false;
            }

        }

        public void PrintReverse()
        {
            for (int i = Count; i > 0 ; i--)
            {
                Console.WriteLine(Tail.Data);
                Tail = Tail.Previous;
            }

        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            int index = 7;
            LinkedListNode myList = new LinkedListNode();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);

            Console.WriteLine("my list's count is " + myList.Count);

            myList.PrintList();

           // Node tempNode = myList.GetNode(3);
           // myList.PrintList();


            bool removeOK = myList.RemoveAt(index);//functionality for removing from the list

            if (removeOK == true)
            {
                
                Console.WriteLine(index);
            }
            else
            {

            }

            myList.PrintReverse();


        }

    }
}
