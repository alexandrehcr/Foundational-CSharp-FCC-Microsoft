// https://learn.microsoft.com/en-us/training/modules/csharp-arrays-operations/7-challenge-2

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderCodes = orderStream.Split(",");

Array.Sort(orderCodes);

foreach (string code in orderCodes)
{
    if (code.Length == 4)
        Console.WriteLine(code);
    else
        Console.WriteLine(code + "\t- Error");
}
