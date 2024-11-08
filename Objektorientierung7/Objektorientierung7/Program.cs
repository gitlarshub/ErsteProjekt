
using Objektorientierung7;

Console.WriteLine("Hello World!");
Cat myCat = new Cat(new DateTime(2008, 01, 18)); // erstellt eine Instanz der Klasse Cat und weißt sie der Variable mit dem Namen myCat zu
myCat.Color = "black";

Console.WriteLine("The color of my Cat is " + myCat.Color);
Console.WriteLine( "The age of my Cat is " + myCat.Age + " years");

Tierheim tierheim = new Tierheim();


tierheim.AddCat(new Cat(new DateTime(2018, 5, 20)) { Color = "Schwarz/Weiß" });
tierheim.AddCat(new Cat(new DateTime(2020, 8, 15)) { Color = "Weiß" });
tierheim.AddCat(new Cat(new DateTime(2016, 3, 10)) { Color = "Grau" });

Console.WriteLine("Katzen im Tierheim:");
tierheim.ListCatsByAge();

Console.WriteLine($"Anzahl der Katzen im Tierheim: {tierheim.GetCatCount()}");