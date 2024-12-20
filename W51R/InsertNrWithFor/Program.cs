
internal class Program
{
    static void Main()
    {
        Console.Write("Sisesta tärnide arv: ");
        int kogus = 0;
        if (int.TryParse(Console.ReadLine(), out kogus))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < kogus; i++)
            {
                Console.Write("*");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
