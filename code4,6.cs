string[] clothesInput = Console.ReadLine().Split();
int rackCapacity = int.Parse(Console.ReadLine());
Stack<int> clothesStack = new Stack<int>();
int currentRackSum = 0;
int rackCount = 1;
foreach (string clothStr in clothesInput)
{
    int clothValue = int.Parse(clothStr);
    if (currentRackSum + clothValue <= rackCapacity)
    {
        currentRackSum += clothValue;
        clothesStack.Push(clothValue);
    }
    else
    {
        currentRackSum = clothValue;
        clothesStack.Push(clothValue);
        rackCount++;
    }
}
Console.WriteLine(rackCount);