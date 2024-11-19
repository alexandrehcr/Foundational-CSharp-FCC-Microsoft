// https://learn.microsoft.com/en-us/training/modules/csharp-arrays-operations/5-challenge-1

string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(" ");

// invert each word in the array
for (int i = 0; i < words.Length; i++)
{
    string word = words[i];
    char[] chars = word.ToCharArray();
    Array.Reverse(chars);
    words[i] = new string(chars);
}

// join the words together
string reversed = String.Join(" ", words);
Console.WriteLine(reversed);