internal class Program
{
    static void Main()
    {
        Console.Write("Sisesta oma vanus: ");
        Int16 vanus;

        if (!Int16.TryParse(Console.ReadLine(), out vanus))
        {
            Console.WriteLine("Viga: Ei ole täisarv!");
        }
        else if (vanus > 0 && vanus < 18)
        {
            Console.WriteLine("Oled alaealine.");
        }
        else if (vanus >= 18 && vanus < 64)
        {
            Console.WriteLine("Oled täisealine.");
        }
        else if (vanus >= 64)
        {
            Console.WriteLine("Oled pensionär.");
        }
        else
        {
            Console.WriteLine("Viga: Vanus ei vasta nõuetele!");
        }
    }
}