internal class Program
{
    static void Main()
    {
        Console.Write("Sisesta vokaal (i ü u e ö õ o ä a): ");
        String vokaal = Console.ReadLine();

        switch (vokaal.ToLower())
        {
            case "i":
                Console.WriteLine("Kirjutasid " + vokaal);
                break;
            case "ü":
                Console.WriteLine("Kirjutasid " + vokaal);
                break;
            case "u":
                Console.WriteLine("Kirjutasid " + vokaal);
                break;
            case "e":
                Console.WriteLine("Kirjutasid " + vokaal);
                break;
            case "ö":
                Console.WriteLine("Kirjutasid " + vokaal);
                break;
            case "õ":
                Console.WriteLine("Kirjutasid " + vokaal);
                break;
            case "o":
                Console.WriteLine("Kirjutasid " + vokaal);
                break;
            case "ä":
                Console.WriteLine("Kirjutasid " + vokaal);
                break;
            case "a":
                Console.WriteLine("Kirjutasid " + vokaal);
                break;
            default:
                Console.WriteLine("Sobimatu vokaal!");
                break;
        }
    }
}

