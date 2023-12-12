int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue <int> ints = new Queue<int>(input);
Queue<int> nums = new Queue<int>();
foreach (var i in ints)
{
    if (i % 2 == 0)
    { 
    nums.Enqueue(i);
    }
}
Console.WriteLine(String.Join(", ", nums));