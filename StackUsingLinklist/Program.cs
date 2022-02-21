// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
namespace DATA_STRUCTURE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue Using Linked List");
            LinkedListUsingQueue linkedListQueue = new LinkedListUsingQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            Console.WriteLine("The Queue is :");
            linkedListQueue.Display();
            Console.WriteLine("\n---------------------\n");
            Console.WriteLine("Performing Dequeue Operation till queue got empty.....");
            linkedListQueue.Dequeue();
            linkedListQueue.Display();
            Console.WriteLine("\n---------------------\n");
            linkedListQueue.Dequeue();
            linkedListQueue.Display();
            Console.WriteLine("\n---------------------\n");
            linkedListQueue.Dequeue();
            linkedListQueue.Display();
            Console.ReadKey();

        }

    }
}