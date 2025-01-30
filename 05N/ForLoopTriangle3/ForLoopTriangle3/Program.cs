
internal class Program
{
    static void Main()
    {

        Console.Write("Sisesta ridade arv: ");
        Int32 rows = Convert.ToInt32(Console.ReadLine());
        int start = 1;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(start++ + " ");
            }
            Console.WriteLine();
        }
    }
}

