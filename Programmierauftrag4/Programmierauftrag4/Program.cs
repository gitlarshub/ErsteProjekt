using System;

namespace MathematischeOperationen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine natürliche Zahl ein:");
            if (int.TryParse(Console.ReadLine(), out int zahl) && zahl >= 0)
            {
                Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 3 ein, um eine mathematische Operation auszuwählen:");
                Console.WriteLine("1) Quadrat");
                Console.WriteLine("2) Wurzel");
                Console.WriteLine("3) Fakultät");

                if (int.TryParse(Console.ReadLine(), out int auswahl))
                {
                    switch (auswahl)
                    {
                        case 1:
                            int quadrat = zahl * zahl;
                            Console.WriteLine($"Das Quadrat von {zahl} ist {quadrat}.");
                            break;
                        case 2:
                            if (zahl >= 0)
                            {
                                double wurzel = Math.Sqrt(zahl);
                                Console.WriteLine($"Die Wurzel von {zahl} ist {wurzel}.");
                            }
                            else
                            {
                                Console.WriteLine("Wurzel ist für negative Zahlen nicht definiert.");
                            }
                            break;
                        case 3:
                            long fakultät = BerechneFakultät(zahl);
                            Console.WriteLine($"Die Fakultät von {zahl} ist {fakultät}.");
                            break;
                        default:
                            Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie eine Zahl zwischen 1 und 3.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl zwischen 1 und 3 ein.");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine natürliche Zahl ein.");
            }
        }

        static long BerechneFakultät(int zahl)
        {
            if (zahl == 0 || zahl == 1) return 1;
            long ergebnis = 1;
            for (int i = 2; i <= zahl; i++)
            {
                ergebnis *= i;
            }
            return ergebnis;
        }
    }
}
