
internal class Program
{
    static void Main()
    {
        //õpetaja lahendus
        double radius;
        double thickness = 0.4;
        char symbol = '*';

        do
        {
            Console.Write("Enter radius: ");
            if (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
            {
                Console.WriteLine("Radius must be positive number");
            }
        } while (radius <= 0);
        Console.WriteLine();

        double rln = radius - thickness, rOut = radius + thickness;

        for (double y = radius; y >= -radius; --y)
        {
            for (double x = -radius; x < rOut; x += 0.5)
            {
                double value = x * x + y * y;
                if (value >= rln * rln && value <= rOut*rOut)
                {
                    Console.Write(symbol);
                } else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

