string password = "2006";
decimal balance = 2005.50m;

Parol:
Console.Write("Parolunuzu daxil edin: ");
string Parol = Console.ReadLine(); //Parol

if (Parol == password)
{
    Console.Clear();

    Console.WriteLine($"Balansınız {balance}");


Secim:
    Console.Write("Nagdlaşdırma yoxsa Medaxil? (N/M): ");
    char Secim = Console.ReadLine()[0];

    if (Secim == 'N' || Secim == 'n')
    {
        Console.Clear();

        Console.WriteLine($"Balansınız {balance}");

        Console.Write("Meblegi daxil edin: ");
        decimal Balance = decimal.Parse(Console.ReadLine());

        if (Balance <= balance)
        {
            balance -= Balance;
            Console.Clear();
            Console.WriteLine($"Cari {balance}");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Kifayet qeder vesait yoxdur!");
        }

    }


    else if (Secim == 'M' || Secim == 'm')
    {
        Console.Clear();

        Console.WriteLine($"Balansınız {balance}");

        Console.Write("Meblegi daxil edin: ");
        decimal Medaxil = decimal.Parse(Console.ReadLine());

        Console.Clear();

        balance += Medaxil;
        Console.WriteLine($"Cari balans {balance}");
    }

    else
    {
        Console.Clear();
        Console.WriteLine("Duzgun secim edin!");
        goto Secim;
    }
}
else
{
    Console.Clear();
    Console.WriteLine("Kod yanlışdır!");
    goto Parol;

}

Thread.Sleep(2000);

Console.WriteLine("Proqramin bitmesini gozleyin. Çixmaq ucun her hansi bir duymeni basin...");
Console.ReadKey();