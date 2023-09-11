using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class LinkedList
    {
        public Node head;
        private int size = 0;
        

        

        public void AddNodeFirst(int data)
        {
            Node newNode = new Node(data);
            size++;

            if (head == null)
            {
                head = newNode;
            }
            else 
            {
                newNode.Next = head;
                head = newNode;

            }
            Console.WriteLine("{0} is inserted into the linkedlist", data);
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                Node currentNode = head;
                while (currentNode != null)
                {
                    Console.Write(currentNode.data + "--->");
                    currentNode = currentNode.Next;
                }
                Console.WriteLine("null");
            }
            
        }
    }
}
