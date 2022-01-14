using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peter_2022._01._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15.feladat: Írj programot, mely beolvas egy pozitív egész számot, és kiírja az egész számokat a
            //képernyőre eddig a számig, egymástól szóközzel elválasztva!
            Console.Write("Kérem adjon meg egy pozitív egész számot. ");
            int N = int.Parse(Console.ReadLine());

            //Számlálós ciklus
            //Paraméterek: Honnan indulunk; Meddig megyünk; Lépésköz;
            for (int i = 1;i<=N;i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Előltesztelős ciklus
            int n = 1;
            while (n<=N)
            {
                Console.Write(n+" ");
                n++;
            }
            Console.WriteLine();
            //Hátultesztelős ciklus
            int k = 1;
            do
            {
                Console.Write(k + " ");
                k++;
            } while (k<=N);
            Console.WriteLine();
            //16.feladat: Írj programot, mely beolvas egy pozitív egész számot, és kiírja az egész számokat
            //egymás alá a képernyőre eddig a számig!
            for (int i = 1; i<=N; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            //17.feladat: Írj programot, mely beolvas egy pozitív egész számot, és kiírja az osztóit!
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    Console.Write(i + ",");
                }
            }
            Console.ReadKey();
        }
    }
}
