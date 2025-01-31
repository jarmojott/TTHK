internal class Program
{
    static void Main()
    {
        Console.WriteLine("Foreach and for loop");

        int[] oddArray = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

        foreach (int item in oddArray)
        {
            //kuni 13 lõpetab loopimise ära
            if (item >= 13)
            {
                break;
            }
            Console.Write(item + " ");
        }
    }
}

