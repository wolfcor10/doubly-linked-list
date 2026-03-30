namespace DoublyLinkedList
{
    public class Program
    {
        public static void Main()
        {
            var list = new DoublyLinkedList<int>();
            list.InsertHead(20);
            list.InsertTail(10);
            list.InsertTail(30);
            list.InsertTail(10);
            list.InsertTail(15);
            list.InsertTail(20);
            list.InsertTail(20);


            Console.WriteLine("Original List:" + list);
            Console.WriteLine("Size: " + list.Size);
            Console.WriteLine("Index of 15: "+ list.Search(15));


            list.RemoveByValue(30);
            Console.WriteLine("After removing 30: " + list);
            Console.WriteLine("Size: " + list.Size);

            list.RemoveDuplicates();
            Console.WriteLine("After removing duplicates: "+ list);
            Console.WriteLine("Size: " + list.Size);


        }
    }
}