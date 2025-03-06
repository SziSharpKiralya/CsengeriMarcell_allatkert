namespace Allatkert
{
    internal class Program
    {
        static List<Allat> allatok = new List<Allat>();

        static void Main(string[] args)
        {
            Random random = new Random();
            int allatokSzama = random.Next(5, 16);
            Console.WriteLine("Üdvözölünk az állatkerben!");

            Console.WriteLine("Állatkert telítettsége:");
            Console.WriteLine("-----------------");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < allatokSzama; i++)
            {
                Console.Write("■");
            }
            for (int i = 0; i < 15 - allatokSzama; i++)
            {
                Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");
            Console.WriteLine("-----------------");

            Pingvin a1 = new Pingvin("Róbert a Pingvin", 3, 2, 6);
            SarkiRoka a2 = new SarkiRoka("Károly A Róka", 2, 6, 11);
            Szarvas a3 = new Szarvas("Béla a Szarvas", 5, 3, 8);
            Zsiraf a4 = new Zsiraf("Paula a Zsiráf", 7, 4, 9);
            Majom a5 = new Majom("Géza a Majom", 4, 5, 7);

            allatok.Add(new Allat(a1.Nev, a1.Sebesseg));
            allatok.Add(new Allat(a2.Nev, a2.Sebesseg));
            allatok.Add(new Allat(a3.Nev, a3.Sebesseg));
            allatok.Add(new Allat(a4.Nev, a4.Sebesseg));
            allatok.Add(new Allat(a5.Nev, a5.Sebesseg));

            Console.Write("Versenyezzenek az állatok? (igen/nem) ");
            string valasz = Console.ReadLine();
            if (valasz == "igen")
            {
                Versenyzes();
            } 
        }

        static void Versenyzes()
        {
            int versenyVege = 50;
            int legelso = 0;
            int lepes = 0;

            while (versenyVege > legelso)
            {
                Thread.Sleep(1000);
                Console.Clear();
                foreach (var allat in allatok)
                {
                    int allatHelyzete = allat.Sebesseg * lepes;
                    if (allatHelyzete > legelso)
                    {
                        legelso = allatHelyzete;
                    }

                    Console.Write($"{allat.Nev} :");
                    for (int i = 0; i < (allatHelyzete); i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("O");
                    Console.WriteLine();
                }

                lepes++;
            }



        }
    }
}
