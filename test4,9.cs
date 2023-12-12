int quantity = int.Parse(Console.ReadLine());
string[] ordersStr = Console.ReadLine().Split();
Queue<int> orders = new Queue<int>();
foreach (string orderStr in ordersStr)
{
    int order = int.Parse(orderStr);
    orders.Enqueue(order);
}
int currentSum = 0;
int biggestOrder = int.MinValue;
while (orders.Count > 0)
{
    int currentOrder = orders.Peek();
    if (currentSum + currentOrder <= quantity)
    {
        currentSum += currentOrder;
        biggestOrder = currentOrder;
        orders.Dequeue();
    }
    else
    {
        break;
    }
}
Console.WriteLine(biggestOrder);
Console.WriteLine("Orders left: " + string.Join(" ", orders));