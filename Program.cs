class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Add First:");
        LinkedList myList1 = new LinkedList();

        myList1.AddFirst(30);
        myList1.AddFirst(70);
        myList1.AddFirst(56);
        myList1.printAllNodes();

        Console.WriteLine();

        Console.WriteLine("Add Last:");
        LinkedList myList2 = new LinkedList();

        myList2.AddLast(56);
        myList2.AddLast(30);
        myList2.AddLast(70);
        myList2.printAllNodes();

        Console.ReadLine();
    }
}