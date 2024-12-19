internal class Program
{
    static void Main()
    {
        //Ruudu sees asub ring. Ringi raadius r on 3.
        //Leia ja väljasta ekraanile ruudu pindala ja ruudu ümbermõõt
        //Leia ja väljasta ekraanile ringi pindala ja ruudu ümbermõõt
        int r = 3;

        //Ringi diameeter (r * 2) on võrdne ruudu külje pikkusega a
        int a = r * 2;

        // Ruudu ümbermõõdu valem
        int P_Ruut = 4 * a;
        // Ruudu pindala valem
        int S_Ruut = a * a;

        // Ringi pindala valem
        double S_Ring = Math.PI * Math.Pow(r, 2);

        // Ringi ümbermõõdu valem
        double P_Ring = 2* Math.PI * r;

        Console.WriteLine("Ruudu ümbermõõt P on " + P_Ruut);
        Console.WriteLine("Ruudu pindala S on " + S_Ruut);

        Console.WriteLine("Ringi ümbermõõt P on " + P_Ring);
        Console.WriteLine("Ringi pindala S on " + S_Ring);
    }
}
