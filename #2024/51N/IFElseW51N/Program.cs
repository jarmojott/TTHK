
using System.Threading.Channels;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Sisesta üks number");
        int number = int.Parse(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine(number + " on negatiivne arv.");
        }
        else if (number > 0)
        {
            Console.WriteLine(number + " on posiitiivne arv.");
        }
        else
        {
            Console.WriteLine("0 pole posiitiivne ega negatiivne arv.");
        }
    }
}
