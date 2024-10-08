int i = 0;
while (i < 10)
{
    Console.WriteLine("Hej!");
    i ++;
}


for (int j=0; j < 10; j++)
{
    Console.WriteLine("Hej!");
}




int ageNum = 0;
bool success = false;

while (success != true)
{
    Console.WriteLine("Age:");
    string age = Console.ReadLine();


    success = int.TryParse(age, out ageNum);

    if (success == false)
    {
        Console.WriteLine("Skriv en siffra!");
    }
}

if (ageNum >= 18)
{
    Console.WriteLine("Welcome!");
}



Console.ReadLine();