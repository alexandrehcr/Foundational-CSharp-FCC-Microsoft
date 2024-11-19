string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

char[] openingSymbols = { '(', '[', '{' };

int closingIndex = 0;
while (true)
{
    int openingIndex = message.IndexOfAny(openingSymbols, closingIndex);

    if (openingIndex == -1) break;

    char closingSymbol = ' ';
    char openingSymbol = message[openingIndex];

    switch (openingSymbol)
    {
        case '(':
            closingSymbol = ')';
            break;
        case '[':
            closingSymbol = ']';
            break;
        case '{':
            closingSymbol = '}';
            break;
    }

    int startIndex = openingIndex + 1;
    closingIndex = message.IndexOf(closingSymbol, openingIndex);
    int length = closingIndex - startIndex;
    Console.WriteLine(message.Substring(startIndex, length));
}

// my initial solution, that also worked was:

// string message
// char[] openingSymbols
// while (true)
// int openingIndex = findAny(openingSymbols)
// if openingIndex -1 break
// char closingchar = ' '
// char openingSymbol = message[openingIndex];
// switch charAtIndex to assign correct char to closingChar
// int startIndex = openingIndex + 1
// int closingIndex = find(closingChar)
// int len = closingIndex - openingIndex
// print message.substring(openingIndex, len)
// message = message.Subtring(closingIndex)
// end while

// I changed it to match the microsoft solution, that doesn't reassign message