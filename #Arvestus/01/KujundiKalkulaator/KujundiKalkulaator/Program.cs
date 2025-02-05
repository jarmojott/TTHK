internal class Program
{
    static void Main()
    {
        Console.WriteLine("Tee oma valik 1-3:");
        Console.WriteLine("1: Ringi pindala");
        Console.WriteLine("2: Ruudu pindala");
        Console.WriteLine("3: Ristküliku pindala");
        Console.Write("Sinu valik: ");
        int valik, r, a, b;

        valik = sisestaNumber();

        switch (valik)
        {
            case 1:
                Console.Write("Sisesta ringi raadius: ");
                r = sisestaNumber();
                Console.WriteLine("Ringi pindala on: " + Math.PI * Math.Pow(r, 2));
                break;
            case 2:
                Console.Write("Sisesta ruudu külg: ");
                a = sisestaNumber();
                Console.WriteLine("Ruudu pindala on: " + Math.Pow(a, 2));
                break;
            case 3:
                Console.Write("Sisesta ristküliku lühem külg: ");
                a = sisestaNumber();
                Console.Write("Sisesta ristküliku pikem külg: ");
                b = sisestaNumber();
                Console.WriteLine("Ruudu pindala on: " + a * b);
                break;
            default:
                Console.WriteLine("Valik ei vasta nõutele!");
                break;
        }
    }

    static int sisestaNumber()
    {
        int number=0;
        while (true)
        {
            int.TryParse(Console.ReadLine(), out number);
            if (number>0){
                return number;
            }
            Console.Write("Palun sisesta korrektne number: ");
        }
    }
}

