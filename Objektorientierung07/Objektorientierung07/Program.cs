using Objektorientierung07;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("Hello World!");
//Cat myCat = new Cat(new DateTime(2008, 01, 18)); // erstellt eine Instanz der Klasse Cat und weißt sie der Variable mit dem Namen myCat zu
//myCat.Color = "black";
//Console.WriteLine("The color of my Cat is " + myCat.Color);
//Console.WriteLine( "The age of my Cat is " + myCat.Age + " years");

Tierheim tierheim = new Tierheim();
List<Animal> cat = new List<Animal>();

cat.Add(new Cat("Luna", new DateTime(2020, 5, 15)));
cat.Add(new Cat("Milo", new DateTime(2018, 3, 10)));
cat.Add(new Cat("Tom", new DateTime(2019, 7, 25)));

Console.WriteLine("Katzen im Tierheim:");
tierheim.ListCatsByAge();

foreach (var animal in cat)
{
    if (animal is Cat katze)
    {
        Console.WriteLine($"Die Katze hat {katze.Beine} Beine.");

        Console.WriteLine("Der typische Laut von der Katze ist:");
        katze.GibTypischenLautVonDir();
    }
}
