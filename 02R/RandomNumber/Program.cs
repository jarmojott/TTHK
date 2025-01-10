internal class Program
{
    public enum Täring
    {
        Yks = 1,
        Kaks = 2,
        Kolm = 3,
        Neli = 4,
        Viis = 5,
        Kuus = 6,
    }
    static void Main()
    {
        Täring tulemus = (Täring)(new Random()).Next(1, 6);

        switch (tulemus)
        {
            case Täring.Yks:
                Console.WriteLine("Täringu tulemus " + (int)tulemus);
                break;
            case Täring.Kaks:
                Console.WriteLine("Täringu tulemus " + (int)tulemus);
                break;
            case Täring.Kolm:
                Console.WriteLine("Täringu tulemus " + (int)tulemus);
                break;
            case Täring.Neli:
                Console.WriteLine("Täringu tulemus " + (int)tulemus);
                break;
            case Täring.Viis:
                Console.WriteLine("Täringu tulemus " + (int)tulemus);
                break;
            case Täring.Kuus:
                Console.WriteLine("Täringu tulemus " + (int)tulemus);
                break;
        }
    }
}
