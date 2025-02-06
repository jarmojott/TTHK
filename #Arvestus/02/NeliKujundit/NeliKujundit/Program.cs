using System.Drawing;

internal class Program
{
    static void Main()
    {
        Console.Write("Millist kujundit soovid (ruut, teemant, ristkylik või kolmnurk): ");
        switch (Console.ReadLine().ToLower())
        {
            case "ruut":
                ruut();
                break;
            case "teemant":
                teemant();
                break;
            case "ristkylik":
                ristkylik();
                break;
            case "kolmnurk":
                kolmnurk();
                break;
            default:
                Console.WriteLine("Sinu valik ei vasta nõutele!");
                break;
        }
    }
    static int sisestaNumber()
    {
        int number = 0;
        while (true)
        {
            int.TryParse(Console.ReadLine(), out number);
            if (number > 0)
            {
                return number;
            }
            Console.Write("Palun sisesta number suurem kui 0: ");
        }
    }

    static void ruut()
    {
        Console.Write("Sisesta ruudu külje pikkus: ");
        int a = sisestaNumber();
        Console.WriteLine();

        for (int row = 1; row <= a; row++)
        {
            for (int column = 1; column <= a; column++)
            {
                string mark;
                if (row == column || row + column <= a + 1)
                {
                    mark = "# ";
                }
                else
                {
                    mark = "# ";
                }
                Console.Write(mark);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Ruudu ümbermõõt: " + 4 * a);
        Console.WriteLine("Ruudu pindala: " + Math.Pow(a, 2));
    }

    static void ristkylik()
    {
        Console.Write("Sisesta ristkyliku lühema külje pikkus: ");
        int a = sisestaNumber();
        Console.Write("Sisesta ristkyliku pikima külje pikkus: ");
        int b = sisestaNumber();
        Console.WriteLine();

        for (int row = 1; row <= b; row++)
        {
            for (int column = 1; column <= a; column++)
            {
                string mark;
                if (row == column || row + column <= a + 1)
                {
                    mark = "# ";
                }
                else
                {
                    mark = "# ";
                }
                Console.Write(mark);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Ristküliku ümbermõõt: " + 2 * (a + b));
        Console.WriteLine("Ristküliku pindala: " + a * b);
    }

    static void kolmnurk()
    {
        Console.Write("Sisesta kolmnurga külje pikkus: ");
        int a = sisestaNumber();
        Console.WriteLine();

        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("# ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Kolmnurga ümbermõõt: " + 3 * a);
        Console.WriteLine("Kolmnurga pindala: " + (Math.Sqrt(3) / 4) * Math.Pow(a, 3));
    }

    static void teemant()
    {
        Console.Write("Sisesta teemandi külje pikkus: ");
        int a = sisestaNumber();
        Console.WriteLine();

        for (int i = 1; i <= a; i++)
        {
            for (int j = 1; j <= a - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("#");
            }
            for (int j = i - 1; j >= 1; j--)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        for (int i = a - 1; i >= 1; i--)
        {
            for (int j = 1; j <= a - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= i; j++)
            {
                Console.Write("#");
            }
            for (int j = i - 1; j >= 1; j--)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Teemandi ümbermõõt: " + 4 * a);
        Console.WriteLine("Teemandi pindala: " + 2 * ((Math.Sqrt(3) / 4) * Math.Pow(a, 3)));
    }
}

