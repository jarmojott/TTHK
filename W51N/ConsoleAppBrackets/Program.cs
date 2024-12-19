
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, Brackets!");
        Console.WriteLine("Kui palju on 3+8/(4-2)*4=?");
        double calculation1 = 3 + 8 / (4 - 2) * 4;
        double calculation2 = (3.0 + 8.0) / (4.0 - 2.0) * 4.0;

        Console.WriteLine(calculation1);
        Console.WriteLine(calculation2);

        double FirstNr = 100;
        double SecondNr = 75;
        double ThirdNr = 50;

        //tehete järjekord tuleb ise määrata ning arvestada komakohti vahearvutustel.
        double equation = FirstNr / (SecondNr * ThirdNr);
        Console.WriteLine(equation);
    }
}
