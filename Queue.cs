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

        public void Display()
        {
            if(Front == null)
            {
                Console.WriteLine("Queue is empty");

            }
            else
            {
                Node temp = Front;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + "  ");
                    temp = temp.Next;
                } 
            }
        }
    }
}
