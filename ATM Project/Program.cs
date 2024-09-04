string password = "2006";
decimal balance = 2005.50m;

Parol:



    Console.Write("Parolunuzu daxil edin: ");
    string Parol = Console.ReadLine();

    if (Parol.All(char.IsDigit))
    {
        

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
                mebleg:
                Console.Write("Meblegi daxil edin: ");
                string input = Console.ReadLine();
                decimal Balance;   

                if (!decimal.TryParse(input, out Balance))
                {
                    Console.Clear();
                    Console.WriteLine("Duzgun reqem daxil edin:");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto mebleg;
                }
                else
                {
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
                        goto Secim;
                    }
            }



            }


            else if (Secim == 'M' || Secim == 'm')
            {
                Console.Clear();

                Console.WriteLine($"Balansınız {balance}");
            mebleg:
                Console.Write("Meblegi daxil edin: ");
                string input = Console.ReadLine();
                 decimal Medaxil;

                if(!decimal.TryParse(input, out Medaxil))
                {
                    Console.Clear();
                    Console.WriteLine("Duzgun reqem daxil edin:");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto mebleg;
                }
                else
                {
                    Console.Clear();

                    balance += Medaxil;
                    Console.WriteLine($"Cari balans {balance}");
                }

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

    }
    else
    {
        Console.Clear();
        Console.WriteLine("Parol reqemlerden ibaret olmalidir!");
        goto Parol;
    }        




Thread.Sleep(2000);

Console.WriteLine("Proqramin bitmesini gozleyin. Çixmaq ucun her hansi bir duymeni basin...");
Console.ReadKey();