
    internal class Program
    {
        static void Main()
        {
            Console.Write("Kas soovid ruutu teha (jah/ei): ");

            if (Console.ReadLine() == "jah") {
            joonistaRuut();
        }
    }

    static void joonistaRuut()
    {
        Console.Write("Mitu sümbolit on ruudu külg: ");
        Int32 sideSize = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= sideSize; i++)
        {
            if (i == 1 || i == sideSize)
            {
                for (int j = 1; j <= sideSize; j++)
                {
                    Console.Write("* ");
                }
            } else
            {
                for (int j = 1; j <= sideSize; j++)
                {
                    if (j == 1 || j == sideSize)
                    {
                        if  (j== sideSize)
                        {
                            Console.Write(" *");
                        } else
                        {
                            Console.Write("*");
                        }
                        
                    } else
                    {
                        Console.Write("  ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
