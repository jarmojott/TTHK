
internal class Program
{
    static void paaris (int arv)
    {
        Console.WriteLine(arv+ " on paaris arv.");
    }

    static void paaritu(int arv)
    {
        Console.WriteLine(arv + " on paaritu arv.");
    }

    static void Main()
    {
        Console.Write("Sisesta arv: ");
        int arv = int.Parse(Console.ReadLine());

        if (int.IsEvenInteger(arv)){
            paaris(arv);
        }
        else
        {
            paaritu(arv);
        }
    }
}
