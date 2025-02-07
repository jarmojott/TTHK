internal class Program
{
    static void Main()
    {
        Console.WriteLine("Teha valik:");
        Console.WriteLine("#1: For tsükkel");
        Console.WriteLine("#2: Foreach tsükkel");
        Console.Write("Sinu valik: #");

        List<string> list = new List<string>() { "Alfa", "Bravo", "Charlie", "Delta", "Echo" };
        switch (Convert.ToInt16(Console.ReadLine()))
        {
            case 1:
                forLoop(list);
                break;
            case 2:
                forEachLoop(list);
                break;
            default:
                Console.WriteLine("Mittesobilik valik!");
                break;
        }
    }
    static void forLoop(List<string> list)
    {
        Console.WriteLine("---For tsükkel---");
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list.ElementAt(i));
        }
    }

    static void forEachLoop(List<string> list)
    {
        Console.WriteLine("---Foreach tsükkel---");
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}

