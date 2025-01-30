
internal class Program
{
    static void Main()
    {
        Int32 rows;

        Console.Write("Sisesta ridade arv: ");
        rows = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}

