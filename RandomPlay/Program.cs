using System;
using System.Collections.Generic;
using System.Linq;

// Abstract class: Player
abstract class Player
{
    public string Name { get; set; }
    public int Score { get; protected set; }

    public abstract void PlayGame(); // Abstract method to update the player's score
}

// Derived class: CasualPlayer
class CasualPlayer : Player
{
    private static Random random = new Random();

    public override void PlayGame()
    {
        Score = random.Next(0, 11); // Random score between 0 and 10
    }
}

// Derived class: ProPlayer
class ProPlayer : Player
{
    private static Random random = new Random();

    public override void PlayGame()
    {
        Score = random.Next(5, 16); // Random score between 5 and 15
    }
}

// Main Program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of players:");
        int n = int.Parse(Console.ReadLine());

        List<Player> players = new List<Player>();

        Console.WriteLine("Enter player details (e.g., 'CasualPlayer John' or 'ProPlayer Alice'):");
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            string playerType = parts[0];
            string playerName = parts[1];

            Player player = null;

            if (playerType == "CasualPlayer")
            {
                player = new CasualPlayer { Name = playerName };
            }
            else if (playerType == "ProPlayer")
            {
                player = new ProPlayer { Name = playerName };
            }
            else
            {
                Console.WriteLine("Invalid player type. Skipping...");
                continue;
            }

            players.Add(player);
        }

        // Simulate the tournament
        foreach (var player in players)
        {
            player.PlayGame();
            Console.WriteLine($"{player.Name} scored {player.Score}");
        }

        // Use LINQ to find the winner
        var winner = players.OrderByDescending(p => p.Score).FirstOrDefault();

        // Output the winner
        if (winner != null)
        {
            Console.WriteLine($"Winner: {winner.Name} with score {winner.Score}");
        }
        else
        {
            Console.WriteLine("No players participated in the tournament.");
        }

        // Use LINQ to filter and sort players with scores greater than 10
        var highScorers = from player in players
                          where player.Score > 10
                          orderby player.Score descending
                          select player;

        Console.WriteLine("\nPlayers with scores greater than 10:");
        foreach (var player in highScorers)
        {
            Console.WriteLine($"{player.Name} scored {player.Score}");
        }
    }
}