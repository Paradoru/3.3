using System;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите x:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите количество повторений:");
                int n = int.Parse(Console.ReadLine());
                double S = 0;
                double b = 0;
                double z = 1;
                long F = 1;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 2; j <= z; j++) F *= j;
                    S = Math.Pow(x, z) / F;
                    z += 4;
                    b += S;
                }
                Console.WriteLine("b={0:F2}", b);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
        }
    }
}
