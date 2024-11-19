string? input;
int enteredNumber = 0;
bool inputAccepted = false;

Console.Write("Enter an integer between 5 and 10: ");

do {
    input = Console.ReadLine();
    if (input != null)
    {
        if (!int.TryParse(input, out enteredNumber))
            Console.WriteLine("This is not a valid number. Please try again.");

        else if (enteredNumber < 5 || enteredNumber > 10)
            Console.WriteLine($"You entered {enteredNumber}. Please provide a number between 5 and 10.");
            
        else
            inputAccepted = true;
    }
} while (!inputAccepted);

Console.WriteLine($"\nYour input was accepted. You entered the number {enteredNumber}.");


