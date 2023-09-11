namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //UC1
            LinkedList<int> list1 = new LinkedList<int>();
            list1.AddFirst(30);
            list1.AddFirst(56);
            list1.AddLast(70);

            foreach (int data in list1)
            {
                Console.Write(data + " ");
            }

            //UC2
            LinkedList list2 = new LinkedList();
            list2.AddNodeFirst(70);
            list2.AddNodeFirst(36);
            list2.AddNodeFirst(56);
            list2.Display();

            //UC3
            LinkedList list3 = new LinkedList();
            list3.AddNodeFirst(56);
            list3.AddNodeLast(30);
            list3.AddNodeLast(70);
            list3.Display();

            //UC4
            LinkedList list4 = new LinkedList();
            list4.AddNodeFirst(56);
            list4.AddNodeLast(70);
            list4.InsertBetween(30, 2);
            list4.Display();

            //UC5
            LinkedList list5 = new LinkedList();
            list5.AddNodeFirst(56);
            list5.AddNodeLast(70);
            list5.InsertBetween(30, 2);
            list5.DeleteFirst();
            list5.Display();

            //UC6
            LinkedList list6 = new LinkedList();
            list6.AddNodeFirst(56);
            list6.AddNodeLast(70);
            list6.InsertBetween(30, 2);
            list6.DeleteLast();
            list6.Display();
        }
    }
}
