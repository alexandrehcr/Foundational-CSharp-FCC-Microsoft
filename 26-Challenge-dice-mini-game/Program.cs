Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    while (true)
    {
        string? input = Console.ReadLine();
        if (input != null)
        {
            if (input.ToLower() == "y")
                return true;

            if (input.ToLower() == "n")
                return false;

            Console.WriteLine("Invalid input. Please insert either 'Y' or 'N'.");
        }
    }
}

int GetTarget()
{
    return random.Next(1, 6);
}

int RollDice()
{
    return random.Next(1, 7);
}

string WinOrLose(int target, int roll)
{
    return roll > target ? "You win!" : "You lose!";
}
