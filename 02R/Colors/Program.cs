internal class Program
{
    public enum Colour { Red, Green, Blue }

    static void Main()
    {


        for (int i = 0; i < 10; i++)
        {
            Colour colour = (Colour)(new Random().Next(0, 2));

            switch (colour)
            {
                case Colour.Red:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Punane");
                    break;
                case Colour.Green:
                    Console.Clear();
                    Console.WriteLine("Roheline");
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case Colour.Blue:
                    Console.WriteLine("Sinine");
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                default:
                    break;

            }
        }

    }
}
