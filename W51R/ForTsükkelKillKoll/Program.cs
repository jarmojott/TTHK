internal class Program
{
    static void Main()
    {
        Console.Write("Sisesta korduste arv: ");
        int kordus = int.Parse(Console.ReadLine());
        for (int i = 0; i < kordus; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("kill-koll ");
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nkilladi-koll");
        }
    }
}