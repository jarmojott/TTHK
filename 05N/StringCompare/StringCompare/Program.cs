
internal class Program
{
    static void Main()
    {
        string[] animalNameS = { "Koer", "Kass", "Jänes", "Sipelgasiil", "Lendorav" };

        NimePikkused(animalNameS);
    }

    static void NimePikkused(string[] animalNameS)
    {
        Console.WriteLine("Loomade tabel: ");
        for (int i = 0; i < animalNameS.Length; i++)
        {
            Console.WriteLine(animalNameS[i] + ": " + animalNameS[i].Length);
        }

        Console.WriteLine();
        Console.WriteLine("Pikim nimi: ");
        for (int i = 0; i < animalNameS.Length; i++)
        {
            if (i != animalNameS.Length - 1)
            {
                if (animalNameS[i].Length < animalNameS[i + 1].Length)     
                {
                    for (int j = 0; j < animalNameS.Length; j++)
                    {
                        if (animalNameS[j].Length < animalNameS[i + 1].Length)
                        {
                            animalNameS[j] = "";
                        }
                    }
                }
            }
        }
        foreach (var item in animalNameS)
        {   if (item.Length > 0)
            {
                Console.WriteLine(item);
            }
        }

    }
}

