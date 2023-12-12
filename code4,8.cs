static bool AreParenthesesBalanced(string sequence)
{
    Stack<char> stack = new Stack<char>();
    foreach (char ch in sequence)
    {
        if (ch == '(' || ch == '{' || ch == '[')
        {
            stack.Push(ch);
        }
        else
        {
            if (stack.Count == 0)
            {
                return false;
            }
            char openParen = stack.Pop();
            if ((openParen == '(' && ch != ')') ||
                (openParen == '{' && ch != '}') ||
                (openParen == '[' && ch != ']'))
            {
                return false;
            }
        }
    }
    return stack.Count == 0;
}
static void Main(string[] args)
{
    string sequence = Console.ReadLine();
    if (AreParenthesesBalanced(sequence))
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}