string[] initialSongs = Console.ReadLine().Split(", ");
Queue<string> songsQueue = new Queue<string>(initialSongs);
while (true)
{
    string command = Console.ReadLine();
    switch (command)
    {
        case "Play":
            if (songsQueue.Count > 0)
            {
                string song = songsQueue.Dequeue();
                Console.WriteLine($"Playing {song}");
            }
            else
            {
                Console.WriteLine("No more songs!");
                return;
            }
            break;
        case var addCommand when addCommand.StartsWith("Add"):
            string[] commandParts = addCommand.Split(" ");
            string songToAdd = commandParts[1];
            if (!songsQueue.Contains(songToAdd))
            {
                songsQueue.Enqueue(songToAdd);
            }
            else
            {
                Console.WriteLine($"{songToAdd} is already contained!");
            }
            break;
        case "Show":
            Console.WriteLine(string.Join(", ", songsQueue));
            break;
        default:
            Console.WriteLine("Invalid command.");
            break;
    }
}