using Code_Refresher;
internal static class Program
{
    public static List<Player> Players = new List<Player>();

    static void Main(string[] args)
    {
        Players.Add(new Player("Alice", 1));
        Players.Add(new Player("Bob", 2));
        Players.Add(new Player("Charlie", 3));
        Players.Add(new Player("David", 4));
        Players.Add(new Player("Eve", 5));

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Display all players");
            Console.WriteLine("2. Display players with odd numbers");
            Console.WriteLine("3. Display players with names starting with a letter");
            Console.WriteLine("4. Add a new player");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        DisplayAllPlayers();
                        break;
                    case 2:
                        DisplayPlayersWithOddNumbers();
                        break;
                    case 3:
                        DisplayPlayersWithNameStartingWithLetter();
                        break;
                    case 4:
                        AddNewPlayer();
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    static void DisplayAllPlayers()
    {
        Console.WriteLine("All Players:");
        foreach (var PLayer in Players)
        {
            Console.WriteLine($"Name: {PLayer.Name}, Number: {PLayer.Number}");
        }
    }

    static void DisplayPlayersWithOddNumbers()
    {
        Console.WriteLine("Players with Odd Numbers:");
        foreach (var PLayer in Players)
        {
            if (PLayer.Number % 2 != 0)
            {
                Console.WriteLine($"Name: {PLayer.Name}, Number: {PLayer.Number}");
            }
        }
    }

    static void DisplayPlayersWithNameStartingWithLetter()
    {
        Console.Write("Enter a letter to filter players: ");
        char letter = Console.ReadLine()?.ToLowerInvariant()[0] ?? ' ';

        Console.WriteLine($"Players with names starting with '{letter}':");
        foreach (var player in Players)
        {
            if (player.Name.ToLowerInvariant()[0] == letter)
            {
                Console.WriteLine($"Name: {player.Name}, Number: {player.Number}");
            }
        }
    }

    static void AddNewPlayer()
    {
        Console.Write("Enter the player's name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the player's number: ");
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            Players.Add(new Player(name, number));
            Console.WriteLine("Player added successfully.");
        }
        else
        {
            Console.WriteLine("Invalid number. Player not added.");
        }
    }
}
        