using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte geben Sie etwas ein:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine("Sie haben eine ganze Zahl eingegeben, welche Mathematische Operaion möchten Sie ausführen?");
            Console.WriteLine("1) Addition");
            Console.WriteLine("2) Multiplikation");
            Console.WriteLine("3) Division");
            Console.WriteLine("4) Fakultät");
            Console.WriteLine("5) Wurzelziehen");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Bitte geben Sie eine zweite Zahl ein:");
                    int addNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ergebnis der Addition: " + (number + addNumber));
                    break;

                case "2":
                    Console.WriteLine("Bitte geben Sie eine zweite Zahl ein:");
                    int multNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ergebnis der Multiplikation: " + (number * multNumber));
                    break;

                case "3":
                    Console.WriteLine("Bitte geben Sie eine zweite Zahl ein:");
                    int divNumber = int.Parse(Console.ReadLine());
                    if (divNumber != 0)
                    {
                        Console.WriteLine("Ergebnis der Division: " + ((double)number / divNumber));
                    }
                    else
                    {
                        Console.WriteLine("Division durch 0 ist nicht möglich.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Ergebnis der Fakultät: " + CalculateFactorial(number));
                    break;

                case "5":
                    if (number >= 0)
                    {
                        Console.WriteLine("Ergebnis des Wurzelziehens: " + Math.Sqrt(number));
                    }
                    else
                    {
                        Console.WriteLine("Die Wurzel einer negativen Zahl ist nicht möglich.");
                    }
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Sie haben eine Zeichenkette eingegeben. Was wollen Sie damit machen?");
            Console.WriteLine("1) Alle Selbstlaute (a,e,i,o,u) entfernen");
            Console.WriteLine("2) Die Zeichenkette umdrehen");
            Console.WriteLine("3) Die Anzahl der Zeichen ausgeben");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Ergebnis: " + RemoveVowels(input));
                    break;

                case "2":
                    Console.WriteLine("Ergebnis: " + ReverseString(input));
                    break;

                case "3":
                    Console.WriteLine("Anzahl der Zeichen: " + input.Length);
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }
    }
    static int CalculateFactorial(int number)
    {
        if (number <= 1)
        {
            return 1;
        }
        return number * CalculateFactorial(number - 1);
    }
    static string RemoveVowels(string input)
    {
        string vowels = "aeiouAEIOU";
        string result = "";
        foreach (char c in input)
        {
            if (!vowels.Contains(c))
            {
                result += c;
            }
        }
        return result;
    }
    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
