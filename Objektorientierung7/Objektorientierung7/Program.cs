
using Objektorientierung7;

Console.WriteLine("Hello World!");
Cat myCat = new Cat(new DateTime(2008, 01, 18)); // erstellt eine Instanz der Klasse Cat und weißt sie der Variable mit dem Namen myCat zu
myCat.Color = "black";

Console.WriteLine("The color of my Cat is " + myCat.Color);
Console.WriteLine( "The age of my Cat is " + myCat.Age + " years");
