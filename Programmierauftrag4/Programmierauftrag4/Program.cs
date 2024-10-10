// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Geben Sie einen Wert ein:");
        string input = Console.ReadLine();

        // Versuche die Eingabe als Bool zu interpretieren
        if (bool.TryParse(input, out bool boolValue) ||
            input.Equals("wahr", StringComparison.OrdinalIgnoreCase) ||
            input.Equals("falsch", StringComparison.OrdinalIgnoreCase))
        {
            if (input.Equals("wahr", StringComparison.OrdinalIgnoreCase))
            {
                boolValue = true;
            }
            else if (input.Equals("falsch", StringComparison.OrdinalIgnoreCase))
            {
                boolValue = false;
            }
            Console.WriteLine($"Der Datentyp ist Bool. Wert: {boolValue}");
        }
        // Versuche die Eingabe als Integer zu interpretieren
        else if (int.TryParse(input, out int intValue))
        {
            Console.WriteLine($"Der Datentyp ist Integer. Wert: {intValue}");
        }
        // Versuche die Eingabe als Double zu interpretieren
        else if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double doubleValue))
        {
            Console.WriteLine($"Der Datentyp ist Double. Wert: {doubleValue}");
        }
        // Versuche die Eingabe als Datum zu interpretieren
        else if (DateTime.TryParse(input, out DateTime dateValue))
        {
            Console.WriteLine($"Der Datentyp ist Datum. Wert: {dateValue.ToShortDateString()}");
        }
        // Fall wenn kein bekannter Datentyp erkannt wurde
        else
        {
            Console.WriteLine("Der Datentyp konnte nicht identifiziert werden.");
        }
    }
}
