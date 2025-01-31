internal class Program
{
    static void Main()
    {
        //Console.WriteLine("Hello, World!");
        String[] genders = { "m", "f", "m", "m", "m", "f", "f", "m", "m", "f" };
        int m = 0, f = 0;

        foreach (var item in genders)
        {
            switch (item)
            {
                case "m":
                    m++;
                    break;
                case "f":
                    f++;
                    break;
            }
           // var result = item == "f" ? f++ : m++;
        }
        Console.WriteLine("Males: " + m + "\nFemales: " + f);
    }
}

