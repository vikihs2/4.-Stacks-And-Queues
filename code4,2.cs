var children = Console.ReadLine().Split(' ');
var number = int.Parse(Console.ReadLine());
Queue<string> queue = new Queue<string>(children);//(shildren) - kopira elementite ot dadenata kolekciq - vzima elemntite ot inputa
while (queue.Count != 1)
{
    for (int i = 1; i < number; i++)
    {
        queue.Enqueue(queue.Dequeue());
    }
    Console.WriteLine($"Removed {queue.Dequeue()}");
}
Console.WriteLine($"Last in {queue.Dequeue()}");