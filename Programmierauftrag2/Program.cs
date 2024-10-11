// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main() {
        Console.WriteLine("Bitte Geben Sie eine natürliche Zahl ein");

        // speichert sie als String 
        string eingabe = Console.ReadLine();

         // int = Zahlen ohne Dazimalstellen
        int zahl;

        // true or false, natürlich
        bool istNatuerlicheZahl = int.TryParse(eingabe, out zahl) && zahl >= 0;

        if(istNatuerlicheZahl) {
            Console.WriteLine($"Die eingegebene Zahl ist: {zahl}");
        }

        else{
            Console.WriteLine("Die eingegebene Zahl ist ungültig!!");
        }
    }
}

