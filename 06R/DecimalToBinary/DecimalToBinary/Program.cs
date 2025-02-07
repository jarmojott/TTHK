
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Decimal to binary");
    
        string binaryNumber = "";
        Console.Write("Input first number: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        while (n1 > 0)
        {
            int reminder = n1 % 2;
            binaryNumber = reminder + binaryNumber;
            n1 /= 2;
        }
        Console.WriteLine(binaryNumber);
    }
}

