string? userInput;
bool inputAccepted = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User): ");

do
{
    userInput = Console.ReadLine();
    if (userInput != null)
    {
        switch (userInput.ToLower().Trim())
        {
            case "administrator":
            case "manager":
            case "user":
                Console.WriteLine($"Your input value ({userInput}) has been accepted.");
                inputAccepted = true;
                break;
            default:
                Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User).");
                break;
        }
    }
} while (!inputAccepted);