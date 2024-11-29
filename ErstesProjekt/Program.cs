// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, SWP!!!");

using System;
// test 123
class Program
{
    static void Main(string[] args)
    {
        string input = "";
        while (true)
        {
            ConsoleKeyInfo keyInfo;
            input = "";

            Console.WriteLine("Geben Sie Text ein. Drücken Sie <Enter> zur Anzeige. Geben Sie 'Beenden' ein, um das Programm zu beenden:");

            do
            {
                keyInfo = Console.ReadKey(intercept: true);


                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                input += keyInfo.KeyChar;
                Console.Write(keyInfo.KeyChar);
            }
            while (keyInfo.Key != ConsoleKey.Enter);


            if (input.Equals("Beenden", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Programm wird beendet.");
                break;
            }
            Console.WriteLine("Eingegebener Text: " + input);
        }
    }
}
