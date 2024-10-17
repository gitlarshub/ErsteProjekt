using System;
using System.Collections.Generic;

namespace MathematischeOperationen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool weiter = true;
            while (weiter)
            {
                ShowMenu();
                int operation = GetValidInput("Bitte wählen Sie eine Operation (1-7): ", 1, 7);
                ExecuteOperation(operation);

                Console.WriteLine("Weitere Berechnung durchführen? (j/n): ");
                weiter = Console.ReadLine().ToLower() == "j";
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("1... Multiplizieren\n2... Dividieren\n3... Addieren\n4... Potenzieren\n5... Wurzelziehen\n6... Fakultät\n7... Invertieren");
        }

        static int GetValidInput(string message, int min, int max)
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input < min || input > max)
                Console.Write(message);
            return input;
        }

        static void ExecuteOperation(int operation)
        {
            Dictionary<int, Func<int, int, double>> twoNumberOperations = new()
            {
                { 1, (x, y) => x * y },
                { 2, (x, y) => y != 0 ? (double)x / y : throw new DivideByZeroException() },
                { 3, (x, y) => x + y },
                { 4, (x, y) => Math.Pow(x, y) }
            };

            Dictionary<int, Func<int, double>> oneNumberOperations = new()
            {
                { 5, x => Math.Sqrt(x) },
                { 6, x => Factorial(x) },
                { 7, x => -x }
            };

            if (twoNumberOperations.ContainsKey(operation))
            {
                int x = GetValidInput("Erste Zahl: ", int.MinValue, int.MaxValue);
                int y = GetValidInput("Zweite Zahl: ", int.MinValue, int.MaxValue);
                try
                {
                    Console.WriteLine($"Ergebnis: {twoNumberOperations[operation](x, y)}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Fehler: Division durch Null!");
                }
            }
            else
            {
                int x = GetValidInput("Zahl: ", int.MinValue, int.MaxValue);
                Console.WriteLine($"Ergebnis: {oneNumberOperations[operation](x)}");
            }
        }

        static double Factorial(int number)
        {
            if (number < 0) return -1;
            double result = 1;
            for (int i = 2; i <= number; i++) result *= i;
            return result;
        }
    }
}

