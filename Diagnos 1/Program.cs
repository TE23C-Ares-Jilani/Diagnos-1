Console.WriteLine("Välkommen!");
Console.WriteLine("Hur många chanser vill du ha att gissa ordet [1-5]?");

int num = 0;
while (num == 0 || num > 5 || num < 1)
{
string gissa = Console.ReadLine();

bool success = int.TryParse(gissa, out num);
if (success == false)
{
    Console.WriteLine("skriv ett nummer.");
}
else if (num > 5)
{
    Console.WriteLine("för högt nummer.");
}
else if (num < 1)
{
    Console.WriteLine("för lågt nummer.");
}
}

int chanser = num;

while (chanser > 0)
{
    Console.WriteLine("Skriv din gissning:");
    String ord = Console.ReadLine();
    if (ord == "falafel")
    {
        Console.WriteLine("Du gissade rätt!");
        Console.WriteLine("hejdå!");
        Console.ReadKey();
        chanser = -1;
    }
    else if (ord == "Falafel")
    {
        Console.WriteLine("Du gissade rätt!");
        Console.WriteLine("hejdå!");
        Console.ReadKey();
        chanser = -1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Fel!");
        chanser--;
    }
}
if (chanser == -1)
{}
else if (chanser == 0)
{
    Console.WriteLine("Du har slut på gissningar.");
    Console.WriteLine("Hejdå!");
    Console.ReadKey();
}

