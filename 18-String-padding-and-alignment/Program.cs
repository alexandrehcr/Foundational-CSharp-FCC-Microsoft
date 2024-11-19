string formattedLine;

// Invoice Example
Console.WriteLine();
Console.WriteLine("1234567890123456789012345678901234567890");
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

formattedLine = "ID".PadRight(6);
formattedLine += "Name".PadRight(24);
formattedLine += "Amount".PadRight(10);
Console.WriteLine(formattedLine);

formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadRight(10);
Console.WriteLine(formattedLine);

Console.WriteLine("\n");

// Restaurant Menu Example
decimal winePrice = 6, waterPrice = 3;
string header = "Drinks";   
int headerLength = header.Length;
int tableLength = 30;
int paddingSize = (tableLength - headerLength) / 2; 
string padding = new string(' ', paddingSize); // padding to centralize the header

Console.WriteLine("123456789012345678901234567890"); // this is a "ruler" to help count the columns of the output
Console.WriteLine(padding + header);
formattedLine = "Item".PadRight(25, '.');
formattedLine += "Price";
Console.WriteLine(formattedLine);

formattedLine = "Water".PadRight(25, '.');
formattedLine += $"{waterPrice:C}";
Console.WriteLine(formattedLine);

formattedLine = "Wine".PadRight(25, '.');
formattedLine += $"{winePrice:C}";
Console.WriteLine(formattedLine);

Console.WriteLine();




