int kr = 100; // Spelaren börjar med 100 kronor

while (kr > 0)
{
    Console.WriteLine($"Du har {kr} kronor.");
    Console.WriteLine("Välj ett föremål att köpa (eller skriv 4 för att avsluta):");
    Console.WriteLine("1. Äpple (10 kr)");
    Console.WriteLine("2. Banan (20 kr)");
    Console.WriteLine("3. Apelsin (30 kr)");
    Console.WriteLine("4. Avsluta");

    int val = int.Parse(Console.ReadLine());

    if (val == 4) // Avsluta spelet om spelaren väljer 4
    {
        Console.WriteLine("Tack för att du handlade! Hejdå!");
        break;
    }

    int pris = val == 1 ? 10 : val == 2 ? 20 : val == 3 ? 30 : 0;

    if (pris == 0) // Ogiltigt val om spelaren väljer något annat än 1, 2, 3 eller 4
    {
        Console.WriteLine("Ogiltigt val. Försök igen.");
        continue;
    }

    Console.WriteLine("Hur många vill du köpa?");
    int antal = int.Parse(Console.ReadLine());
    int totalKostnad = pris * antal;

    if (totalKostnad > kr)
    {
        Console.WriteLine("Det har du inte råd med!");
    }
    else
    {
        kr -= totalKostnad;
        Console.WriteLine($"Du köpte {antal} föremål för totalt {totalKostnad} kr. Du har {kr} kr kvar.");
    }
}

if (kr <= 0)
{
    Console.WriteLine("Du har slut på pengar! Spelet är över.");
}


Console.ReadLine();