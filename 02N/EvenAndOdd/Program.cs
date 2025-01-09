internal class Program
{
    static void Main()
    {
        Console.Write("Sisesta number: ");
        int arv = int.Parse(Console.ReadLine());

        if (int.IsEvenInteger(arv))
        {
            Console.WriteLine("Paaris arv.");
        } else
        {
            Console.WriteLine("Paaritu arv.");
        }

        if ( arv % 2 ==0)
        {
            Console.WriteLine("Paaris arv.");
        }
        else
        {
            Console.WriteLine("Paaritu arv.");
        }
    }
}
