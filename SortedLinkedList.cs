using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SortedLinkedList<T> where T : IComparable<T>
    {
        private GenericNode<T> head;

        public void Add(T data)
        {
            GenericNode<T> newNode = new GenericNode<T>(data);

            if (head == null || data.CompareTo(head.Data) < 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                GenericNode<T> current = head;

                while (current.Next != null && data.CompareTo(current.Next.Data) >= 0)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public void Display()
        {
            GenericNode<T> current = head;

            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }

            Console.WriteLine("null");
        }
    }
}
