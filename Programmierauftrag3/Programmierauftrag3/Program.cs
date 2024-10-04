
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Geben Sie einen Wert ein:");

        string input = Console.ReadLine();

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
       
        else if (int.TryParse(input, out int intValue))
        {
            Console.WriteLine($"Der Datentyp ist Integer. Wert: {intValue}");
        }
        else if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double doubleValue))
        {
            Console.WriteLine($"Der Datentyp ist Double. Wert: {doubleValue}");
        }
        else if (DateTime.TryParse(input, out DateTime dateValue))
        {
            Console.WriteLine($"Der Datentyp ist Datum. Wert: {dateValue.ToShortDateString()}");
        }
        else
        {
            Console.WriteLine("Der Datentyp konnte nicht identifiziert werden.");
        }
    }
}



