
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Tere tulemast!\n");
        Console.WriteLine("Menüü:");
        Console.WriteLine("1. Väike tass");
        Console.WriteLine("2. Keskmine tass");
        Console.WriteLine("3. Suur tass");

        Console.Write("\nSinu valik: ");

        byte coffeeSize = byte.Parse(Console.ReadLine());
        double price = 0.25;

        switch (coffeeSize)
        {
            case 1:
                price += 1.5;
                break;
            case 2:
                price += 2.5;
                break;
            case 3:
                price += 3; break;
            default:
                price = 0;
                Console.WriteLine("VIGA!");
                break;
        }
        Console.WriteLine("Hind: {0:f2}", price);
    }
}
