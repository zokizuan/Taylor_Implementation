
using System;

namespace Taylor_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            int x = 2;
            //Convert.ToInt32(Console.ReadLine());
            double Sin_x = x - Magic(x, i);
            Console.WriteLine("hehe" + Sin_x);

            for (; true; )
            {
                double f = Sin_x;
                Sin_x = Sin_x - Magic(x, i += 2);
                Console.WriteLine(Sin_x);
                if ((f- Sin_x) < 0.00000000001)
                {
                    break;
                }
            }
        }


        static int GetFactorial(int number)
        {
            int e = number;
            if (number > 1)
            {
                return number * GetFactorial(number - 1);
            }
            else return 1;
        }

        static double Magic(int Z, int Y)
        {
            int z, y;
            z = Z;
            y = Y;
            double m = (Math.Pow(z, y) / GetFactorial(y));
            return m;
        }

    }

}
