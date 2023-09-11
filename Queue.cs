using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Queue
    {
        Node Front;
        Node Rear;

        public void enqueueData(int data)
        {
            Node nodeObj = new Node(data);

            if(Front == null)
            {
                Rear = nodeObj;
                Front = Rear;
            }
            else
            {
                Rear.Next = nodeObj;
                Rear = Rear.Next;
            }
        }

        public void dequeueData()
        {
            if (Front == null)
            {
                Console.WriteLine("The Queue is empty");
            }
            else
            {
                Node currentNode = Front;
                Node nextNode = Front.Next;
                while (nextNode.Next != null)
                {
                    currentNode = nextNode;
                    nextNode = nextNode.Next;
                }
                currentNode.Next = null;
            }
        }

        public void Display()
        {
            if(Front == null)
            {
                Console.WriteLine("Queue is empty");

            }
            else
            {
                Node temp = Front;
                Console.Write("Front--->");
                while (temp != null)
                {
                    Console.Write(temp.data + "--->");
                    temp = temp.Next;
                }
                Console.WriteLine("Rear");
            }
        }
    }
}
