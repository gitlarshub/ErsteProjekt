using SWP_Test02;

Schule schule = new Schule();

schule.AddSchüler(new Schueler("Burak Mustermann", "Männlich", new DateTime(2008, 1, 23), "3aWi"));
schule.AddSchüler(new Schueler("Mark Peter", "Männlich", new DateTime(2005, 5, 15), "3bWi"));
schule.AddSchüler(new Schueler("Anna Mayer", "Weiblich", new DateTime(2006, 7, 20), "3bWi"));
schule.AddSchüler(new Schueler("Thomas Wayne", "Männlich", new DateTime(2004, 11, 10), "3aWi"));
schule.AddSchüler(new Schueler("Erik Quelle", "Männlich", new DateTime(2006, 9, 1), "3bWi"));
schule.AddSchüler(new Schueler("Maria Kolanovic", "Weiblich", new DateTime(2007, 1, 1), "3aWi"));
schule.AddSchüler(new Schueler("Lars Veljava", "Männlich", new DateTime(2007, 11, 11), "3bWi"));
schule.AddSchüler(new Schueler("Isabell Kopf", "Weiblich", new DateTime(2005, 4, 23), "3bWi"));


schule.AddKlassenraum(new Klassenraum("187", 50, 20, true));
schule.AddKlassenraum(new Klassenraum("181", 40, 15, true));

Console.WriteLine($"Gesamtanzahl der Schüler: {schule.GetAnzahlSchüler()}");
Console.WriteLine($"Anzahl männlicher Schüler: {schule.GetAnzahlSchülerNachGeschlecht("Männlich")}");
Console.WriteLine($"Anzahl weiblicher Schüler: {schule.GetAnzahlSchülerNachGeschlecht("Weiblich")}");
Console.WriteLine($"Anzahl der Klassenräume: {schule.GetAnzahlKlassenräume()}");
Console.WriteLine($"Durchschnittsalter der Schüler: {schule.GetDurchschnittsalter():0.00} Jahre");

Console.WriteLine("\nRäume mit Cynap:");
foreach (var raum in schule.GetRäumeMitCynap())
{
    Console.WriteLine($"Der Klassenraum {raum.RaumId} hat Cynap und {raum.Plaetze} Plätze");
}

Console.WriteLine("\nKlasseninformationen:");
foreach (var klasse in schule.GetKlassenMitAnzahlSchüler())
{
    Console.WriteLine($"Klasse: {klasse.Key}, Anzahl Schüler: {klasse.Value}");
}

string klasseAbfrage = "3bWi";
Console.WriteLine($"\nFrauenanteil in der Klasse von der {klasseAbfrage}: {schule.GetFrauenanteil(klasseAbfrage):0.00}%");

string raumAbfrage = "187";
bool kannUnterrichtetWerden = schule.KannKlasseRaumNutzen(klasseAbfrage, raumAbfrage);
Console.WriteLine($"\nKann die Klasse {klasseAbfrage} im Raum {raumAbfrage} unterrichtet werden? {kannUnterrichtetWerden}");