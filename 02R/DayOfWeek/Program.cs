internal class Program
{
    static void Main()
    {
        switch (DateTime.Now.DayOfWeek)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("Esmaspäev");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("Teisipäev");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("Kolmapäev");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("Neljapäev");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("Reede");
                break;
            case DayOfWeek.Saturday:
                Console.WriteLine("Laupäev");
                break;
            case DayOfWeek.Sunday:
                Console.WriteLine("Pühapäev");
                break;
        }
    }
}

