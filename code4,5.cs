int size = int.Parse(Console.ReadLine());
int remove = int.Parse(Console.ReadLine());
int theNum = int.Parse(Console.ReadLine());
Queue<int> ints = new Queue<int>();
for (int i = 0; i < size; i++)
{ 
    int element = int.Parse(Console.ReadLine());
    ints.Enqueue(element);
}
for (int i = 0; i <= remove; i++)
{
    if (ints.Count > 0)
    { 
    ints.Dequeue();
    }
}
if (ints.Contains(theNum))
{
    Console.WriteLine("true");
}
else if (ints.Count > 0)
{
    int smallest = ints.Peek();
    foreach (int element in ints)
    {
        if (element < smallest)
        { 
        smallest = element;
        }
    }
    Console.WriteLine(smallest);
}
else
{
    Console.WriteLine("0");
}