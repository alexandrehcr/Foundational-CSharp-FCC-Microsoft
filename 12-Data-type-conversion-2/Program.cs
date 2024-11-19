int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Convert will round the result of the division
int result1 = Convert.ToInt32(value1 / value2); // value1 is implicitly promoted to decimal, as there's a decimal in the operation
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal) value3; // widening explicit conversion (float -> decimal)
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1; // value1 is implicitly promoted to float, as there's a float in the operation
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
