// https://learn.microsoft.com/en-us/training/modules/challenge-project-create-mini-game/

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = { "('-')", "(^-^)", "(X_X)" };
string[] foods = { "@@@@@", "$$$$$", "#####" };

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit)
{
    if (TerminalResized())
    {
        Console.Clear();
        Console.WriteLine("Console was resized. Program exiting.");
        break;
    }

    if (IsPlayerExcited(player))
        Move(speed: 1);
    else
        Move();

    if (WasFoodEaten(playerX, playerY, foodX, foodY))
    {
        ChangePlayer();
        if (IsPlayerPoisoned(player))
            FreezePlayer();
        ShowFood();
    }
}


// Returns true if the Terminal was resized 
bool TerminalResized()
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Clears the console, displays the food and player
void InitializeGame()
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}

// Displays random food at a random location
void ShowFood()
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer()
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer()
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move(int speed = 1, bool otherKeysExit = false)
{
    int lastX = playerX;
    int lastY = playerY;

    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.UpArrow:
        case ConsoleKey.W:
            playerY--;
            break;

        case ConsoleKey.DownArrow:
        case ConsoleKey.S:
            playerY++;
            break;

        case ConsoleKey.LeftArrow:
        case ConsoleKey.A:
            playerX -= speed;
            break;

        case ConsoleKey.RightArrow:
        case ConsoleKey.D:
            playerX += speed;
            break;

        case ConsoleKey.Escape:
            shouldExit = true;
            break;

        default:
            if (otherKeysExit)
            {
                Console.Clear();
                System.Console.WriteLine("Non-directional input key pressed. Program exiting.");
                shouldExit = true;
                return;
            }
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++)
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

/*
    This method returns true only when the center of the player matches the center of the food string (the third chars of each one align), which implies that all the food was eaten.
    If it were to recognize that the food was eaten as soon as the player overlaps the first food character, the player X coordinate should be greater than or equal to the food x coordinate minus 4 (foodX - 4). Why is it 4, though?
*/
bool WasFoodEaten(int playerX, int playerY, int foodX, int foodY)
{
    return playerX == foodX && playerY == foodY;
}

bool IsPlayerPoisoned(string player)
{
    return player == "(X_X)";
}

bool IsPlayerExcited(string player)
{
    return player == "(^-^)";
}