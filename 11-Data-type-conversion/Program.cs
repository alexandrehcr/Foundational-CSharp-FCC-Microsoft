string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
double total = 0.0;

foreach (string s in values)
{
    double result;
    if (double.TryParse(s, out result))
        total += result;
    else
        message += s;
}

System.Console.WriteLine("Message: " + message);
System.Console.WriteLine("Total: " + total);