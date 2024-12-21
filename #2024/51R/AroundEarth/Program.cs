
internal class Program
{
    static void Main()
    {
        // 25.75mm
        double d_coinDiameterInKm = 25.75 / 1000000;
        double r_earthRadiusInKm = 6378;

        double C_EarthInKm = 2 * Math.PI * r_earthRadiusInKm;

        double CoinCount = C_EarthInKm / (d_coinDiameterInKm);
        Console.WriteLine("2 euroste müntide arv ümber maakera: " + CoinCount);
    }
}
