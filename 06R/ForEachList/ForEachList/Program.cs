internal class Program
{
    static void Main()
    {
        Console.WriteLine("-Foreach list-");
        List<int> numbers = new List<int>() { 5, -8, 3, 14, 9, 17, 0, 4 };

        int sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }
        Console.WriteLine(sum);
    }
}