using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N:");
            int N = int.Parse(Console.ReadLine());
            int S1 = 6;
            int S2 = 11;
            int S3 = 16;
            double S = 0;
            int P = 23;
            for (int k = 1; k <= N; k++)
            {
                S1 += S1 + 5;
                S2 += S2 * 2;
                S3 += S3 * 3;
                S += P - S1 / (S2 * S3);
            }
            Console.WriteLine($"Ответ {S}");
        }
    }
}
