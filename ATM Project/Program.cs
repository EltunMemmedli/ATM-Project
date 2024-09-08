string password = "2006";
decimal balance = 2005.50m;

Parol:



    Console.Write("Parolunuzu daxil edin: ");
    string Parol = Console.ReadLine();
    int parol;

    
    if (int.TryParse(Parol, out parol) && parol > 0)
    {
        

        if (Parol == password)
        {
            Console.Clear();

            Console.WriteLine($"Balansınız {balance}");


        Secim:
            Console.Write("Nagdlaşdırma yoxsa Medaxil? (N/M): ");
            string Secim = Console.ReadLine();

            if (Secim == "N" || Secim == "n")
            {
                Console.Clear();

                Console.WriteLine($"Balansınız {balance}");
                mebleg:
                Console.Write("Meblegi daxil edin: ");
                string input = Console.ReadLine();
                decimal Balance;   

                if (decimal.TryParse(input, out Balance) && Balance > 0)
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
                else
                {
                    Console.Clear();
                    Console.WriteLine("Duzgun reqem daxil edin:");
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto mebleg;
                }



            }


            else if (Secim == "M" || Secim == "m")
            {
                Console.Clear();

                Console.WriteLine($"Balansınız {balance}");
                mebleg:
                Console.Write("Meblegi daxil edin: ");
                string input = Console.ReadLine();
                decimal Medaxil;

                if(!decimal.TryParse(input, out Medaxil) && Medaxil > 0)
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

            else if (string.IsNullOrWhiteSpace(Secim))
            {
                Console.Clear();
                Console.WriteLine("Duzgun secim edin!");
                goto Secim;
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
        Console.WriteLine("Parolu duzgun yazin!");
        goto Parol;
    }        




Thread.Sleep(2000);

Console.WriteLine("Proqramin bitmesini gozleyin. Çixmaq ucun her hansi bir duymeni basin...");
Console.ReadKey();