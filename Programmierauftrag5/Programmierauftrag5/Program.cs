using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bitte geben Sie einen String ein:");
        string input = Console.ReadLine().ToLower();

        int vowelCount = CountVowels(input);

        Console.WriteLine($"Die Anzahl der Selbstlaute in Ihrem String ist: {vowelCount}");

        string reversed = ReverseString(input);
        Console.WriteLine($"Der umgekehrte String lautet: {reversed}");

        string trimmed = input.Trim();
        Console.WriteLine($"String ohne führende und nachfolgende Leerzeichen: '{trimmed}'");
    }
    static int CountVowels(string str)
    {
        int count = 0;
        string vowels = "aeiou";

        foreach (char c in str)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }
        return count;
    }
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
