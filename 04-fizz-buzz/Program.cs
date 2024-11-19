for (int i = 1; i <= 100; i++)
{
    Console.Write(i);
    if (i % 3 == 0)
    {
        if (i % 5 == 0)
            Console.Write("\t- FizzBuzz");
        else
            Console.Write("\t- Fizz");
    } 
    else if (i % 5 == 0)
    {
        Console.Write("\t- Buzz");
    }
    Console.WriteLine();
}