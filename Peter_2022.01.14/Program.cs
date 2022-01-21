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
                    if (i == N)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + ",");
                    }                  
                }
            }
            Console.WriteLine();
            
            //Console.Write(N);
            //18.feladat: Írj programot, mely beolvas egy pozitív egész számot, és kiírja az osztóinak az
            //összegét!
            //Összegzés törvényét használjuk a feladatmegoldás során!
            int osszeg = 0;
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {                 
                    osszeg = osszeg + i;
                }
            }
            Console.WriteLine($"{N}-ig az osztahtó számok összege: {osszeg}");

            //19.feladat: Írj programot, mely beolvas egy pozitív egész számot, és megmondja, hogy
            //tökéletes szám-e!(A tökéletes számok azok, melyek osztóinak összege egyenlő a
            //szám kétszeresével.
            int osszeg_tokeletes = 0;
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    osszeg_tokeletes = osszeg_tokeletes + i;
                }
            }
            if (2*N == osszeg_tokeletes)
            {
                Console.WriteLine($"Tökéletes szám!");
            }
            else
            {
                Console.WriteLine($"NEM tökéletes szám!");
            }

            //20.feladat: Írj programot, mely beolvassa a hatvány alapját és a kitevőt, és kiírja a
            //hatványértéket!
            Console.Write("Kérem adje meg a hatvány alapját: ");
            int alap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adje meg a hatvány kitevőjét: ");
            int kitevo = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"{alap}^{kitevo}={Math.Pow(alap,kitevo)}");
            Console.ReadKey();
        }
    }
}
