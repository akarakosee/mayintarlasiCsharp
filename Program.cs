using System;

class Program
{
    static void Main(string[] args)
    {
        int boyut = 5;
        int mayinSayisi = 3;

        int[,] oyunTahtasi = new int[boyut, boyut];
        char[,] gosterilenTahta = new char[boyut, boyut];

        Random rnd = new Random();

        // Mayınları yerleştir
        for (int i = 0; i < mayinSayisi; i++)
        {
            int x = rnd.Next(boyut);
            int y = rnd.Next(boyut);

            oyunTahtasi[x, y] = -1;
        }

        // Oyun Tahtasını göster
        Console.WriteLine("Oyun Tahtası:");
        for (int i = 0; i < boyut; i++)
        {
            for (int j = 0; j < boyut; j++)
            {
                Console.Write("* ");
                gosterilenTahta[i, j] = '*';
            }
            Console.WriteLine();
        }

        // Oyun başlar
        bool devam = true;
        while (devam)
        {
            Console.Write("Satır giriniz (1-5): ");
            int x = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.Write("Sütun giriniz (1-5): ");
            int y = Convert.ToInt32(Console.ReadLine()) - 1;

            if (oyunTahtasi[x, y] == -1)
            {
                Console.WriteLine("Mayına bastınız! Oyun bitti.");
                gosterilenTahta[x, y] = 'X';
                devam = false;
            }
            else
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Mayın yok!");
                gosterilenTahta[x, y] = 'O';
                for (int i = 0; i < boyut; i++)
                {
                    for (int j = 0; j < boyut; j++)
                    {
                        Console.Write(gosterilenTahta[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        Console.ReadLine();
    }
}
