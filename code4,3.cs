int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> stack = new Stack<int>(input);
while (true)
{
    string[] command = Console.ReadLine().Split();
    switch (command[0])
    {
        case "end":
            int sum = stack.Sum();
            Console.WriteLine(sum);
            return;
            case "add":
            int n = int.Parse(command[1]);
            int m = int.Parse(command[2]);
            stack.Push(n);
            stack.Push(m);
            break;
        case "remove":
            int count = int.Parse(command[1]);
            if (count <= stack.Count)
            {
                for (int i = 0; i < count; i++)
                {
                    stack.Pop();
                }
            }
            break;
    }
}