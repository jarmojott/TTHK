internal class Program
{
    static void Main()
    {
        Console.Write("Sisesta summa sentides: ");
        int sum = int.Parse(Console.ReadLine());
        Coins(sum);
    }

    static void Coins(int sum)
    {
        //int coin1 = 0, coin2 = 0, coin5 = 0, coin10 = 0, coin20 = 0, coin50 = 0;

        int[,] coins = new int[6, 2];
        coins[0, 0] = 50;
        coins[0, 1] = 0;
        coins[1, 0] = 20;
        coins[1, 1] = 0;
        coins[2, 0] = 10;
        coins[2, 1] = 0;
        coins[3, 0] = 5;
        coins[3, 1] = 0;
        coins[4, 0] = 2;
        coins[4, 1] = 0;
        coins[5, 0] = 1;
        coins[0, 1] = 0;

        while (sum > 0)
        {
            for (int i = 0; i < 6; i++)
            {
                if (sum - coins[i, 0] >= 0)
                {
                    sum -= coins[i, 0];
                    coins[i, 1]++;
                    break;
                }
            }

            //if (summa - 50 >= 0)
            //{
            //    summa = summa - 50;
            //    coin50++;
            //}
            //else if (summa - 20 >= 0)
            //{
            //    summa = summa - 20;
            //    coin20++;
            //}
            //else if (summa - 10 >= 0)
            //{
            //    summa = summa - 10;
            //    coin10++;
            //}
            //else if (summa - 5 >= 0)
            //{
            //    summa = summa - 5;
            //    coin5++;
            //}
            //else if (summa - 2 >= 0)
            //{
            //    summa = summa - 2;
            //    coin2++;
            //}
            //else if (summa - 1 >= 0)
            //{
            //    summa = summa - 1;
            //    coin1++;
            //}
        }
        //Console.WriteLine("50c: " + coin50);
        //Console.WriteLine("20c: " + coin20);
        //Console.WriteLine("10c: " + coin10);
        //Console.WriteLine("5c: " + coin5);
        //Console.WriteLine("2c: " + coin2);
        //Console.WriteLine("1c: " + coin1);

        for (int i = 0; i < 6; i++)
        {
            if (coins[i, 1] > 0)
            {
                Console.WriteLine(coins[i, 0] + "c: " + coins[i, 1]);
            }
        }
    }
}

