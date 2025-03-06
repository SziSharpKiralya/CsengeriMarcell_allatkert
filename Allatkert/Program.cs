namespace Allatkert
{
    internal class Program
    {
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
            for (int i = 0; i < 15-allatokSzama; i++)
            {
                Console.Write(" ");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");
            Console.WriteLine("-----------------");



        }
    }
}
