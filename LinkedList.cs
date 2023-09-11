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

        public void AddNodeLast(int data)
        {
            Node newNode = new Node(data);
            size++;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node currentNode = head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }

            Console.WriteLine("{0} is inserted into the linkedlist", data);
        }

        public void InsertBetween(int data, int position)
        {
            Node newNode = new Node(data);
            size++;

            if (head == null)
            {
                head = newNode;
            }
            else if (head.Next == null)
            {
                head.Next = newNode;
            }
            else
            {
                Node currentNode = head;
                for (int i = 1; i < position - 1; i++)
                {
                    currentNode = currentNode.Next;
                }
                newNode.Next = currentNode.Next;
                currentNode.Next = newNode;
            }
            Console.WriteLine("{0} is inserted into the linkedlist", data);

        }

        public void DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            else
            {
                size--;
                head = head.Next;
            }
        }

        public void DeleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("This list is empty");
            }
            else if (head.Next == null)
            {
                head = null;
                size--;
            }
            else
            {
                Node secondLastNode = head;
                Node lastNode = head.Next;
                while (lastNode.Next != null)
                {
                    secondLastNode = lastNode;
                    lastNode = lastNode.Next;
                }
                secondLastNode.Next = null;
                size--;
            }
        }

        public int SearchElement(int value)
        {
            Node currentNode = head;
            int index = -1;
            int found = 0;

            if (currentNode == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                while (currentNode != null)
                {
                    index++;
                    if (currentNode.data == value)
                    {
                        found++;
                        break;
                    }
                    currentNode = currentNode.Next;
                }
                if (found == 1)
                {
                    return index;
                }
            }
            return -1;
        }

        public void InsertAfter(int data, int value)
        {
            Node newNode = new Node(data);
            size++;

            int index = SearchElement(value);

            if (index != -1)
            {
                Node currentNode = head;
                for (int i = 1; i < index + 1; i++)
                {
                    currentNode = currentNode.Next;
                }
                newNode.Next = currentNode.Next;
                currentNode.Next = newNode;
                Console.WriteLine("{0} is inserted into the linkedlist", data);
            }

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
