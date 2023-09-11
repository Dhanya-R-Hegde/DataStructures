namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //UC1
            //LinkedList<int> list1 = new LinkedList<int>();
            //list1.AddFirst(30);
            //list1.AddFirst(56);
            //list1.AddLast(70);

            //foreach (int data in list1)
            //{
            //    Console.Write(data + " ");
            //}

            //UC2
            LinkedList list2 = new LinkedList();
            list2.AddNodeFirst(70);
            list2.AddNodeFirst(36);
            list2.AddNodeFirst(56);
            list2.Display();



        }
    }
}
