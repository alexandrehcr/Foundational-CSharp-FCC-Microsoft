// https://learn.microsoft.com/en-us/training/modules/create-c-sharp-methods-parameters/6-exercise-challenge-email-addresses

string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";


for (int i = 0; i < corporate.GetLength(0); i++)
{
    // the use of named arguments can let the code more meaningful without the need to declare variables for that
    DisplayEmployeesEmails(firstName: corporate[i, 0], lastName: corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    DisplayEmployeesEmails(firstName: external[i, 0], lastName: external[i, 1], domain: externalDomain);
}


void DisplayEmployeesEmails(string firstName, string lastName, string domain = "contoso.com")
{
    string username = (firstName.Substring(0, 2) + lastName).ToLower();
    Console.WriteLine($"{username}@{domain}");
}


