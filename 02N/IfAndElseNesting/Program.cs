internal class Program
{
    static void Main()
    {
        Console.WriteLine("Sisesta fooritule värv punane/kollane/roheline");
        String color = Console.ReadLine().ToLower();

        if (color == "punane" || color == "kollane" || color == "roheline")
        {
            if (color == "punane")
            {
                Console.WriteLine("Ei tohi edasi sõita");
            }
            else if (color == "kollane")
            {
                Console.WriteLine("Foorituli kohe vahetub, oota...");
                Thread.Sleep(3000);
                Console.WriteLine("Nüüd võib edasi sõita");
            }
            else
            {
                Console.WriteLine("Praegu võib sõita!");
            }
        }
        else
        {
            Console.WriteLine("Viga: mittesobilik väärtus!");
        }
    }
}

