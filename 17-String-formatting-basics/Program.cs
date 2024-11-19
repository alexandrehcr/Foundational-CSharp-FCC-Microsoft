using System.Globalization;

string first = "Hello";
string second = "World";

// Compositing Formatting
string result = String.Format("{1} {0}!", first, second);
Console.WriteLine(result); // World Hello!
Console.WriteLine("{0} {0} {0}!", first, second); // Hello Hello Hello


Console.WriteLine(new string('-', 30));


// String Interpolation
Console.WriteLine($"{first} {second}!"); // Hello World
Console.WriteLine($"{second} {first}!"); // World Hello
Console.WriteLine($"{first} {first} {first}!"); // Hello Hello Hello


Console.WriteLine(new string('-', 30));


// Currency Formatting
decimal price = 123.45m;
int discount = 50;

// the :C currency format specifier is used to present the price and discount variables as currency. 
// The formatting is based on the computer culture. If you want to change, 
//declare `using System.Globalization` and change the CultureInfo as follows
CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
CultureInfo.CurrentCulture = new CultureInfo("pt-PT");
CultureInfo.CurrentCulture = new CultureInfo("en-US");

Console.WriteLine($"Price: {price:C} (Save {discount:C})");


Console.WriteLine(new string('-', 30));


// Numbers Formatting
// The N numeric format specifier makes numbers more readable
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

// By default, the N numeric format specifier displays only two digits after the decimal point.
// If you want to display more precision, you can do that by adding a number after the specifier.
Console.WriteLine($"Measurement: {measurement:N4} units");


Console.WriteLine(new string('-', 30));


// Formatting Percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");


Console.WriteLine(new string('-', 30));


// Combining Formatting Approaches
price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// You don't need to use String.Format() with the string interpolation approach.
yourDiscount += $"A discount of {(price - salePrice)/price:P2}!";
Console.WriteLine(yourDiscount);


Console.WriteLine(new string('-', 30));

