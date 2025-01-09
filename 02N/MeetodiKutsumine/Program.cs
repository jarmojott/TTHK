internal class Program
{
    static void Main()
    {
        Console.WriteLine("Käivitub põhimeetod..");
        Jalgratas();
        Console.Write("Sisesta uste arv: ");
        Buss(int.Parse(Console.ReadLine()));
    }
    private static void Jalgratas()
    {
        Console.WriteLine("Käivatasid meetodi: Jalgratas.");
    }

    private static void Buss(int uks)
    {
        Console.WriteLine("Käivatasid meetodi: Buss koos "+ uks+ " uksega");
    }
}

