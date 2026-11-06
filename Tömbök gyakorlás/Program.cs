using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Tömbök_gyakorlás
{
    internal class Program
    {
        static void keresettElso(int[] tomb1, int kereset)
        {
           Console.WriteLine($"keresett {kereset}, index {Array.IndexOf(tomb1, kereset)}");
        }
        static void keresettUtolso(int[] tomb1, int kereset)
        {
            Console.WriteLine($"keresett {kereset}, index {Array.LastIndexOf(tomb1, kereset)}");
        }
        static void Felett(int[] tomb1)
        {
            int sum = 0;
            foreach(int x  in tomb1)
            {
                if (x > 50)
                {
                    Console.Write($"{x}, ");
                    sum += x;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"összesen, {sum}");
        }
        static void Darab(int[] tomb1, int keresett)
        {
            int db = 0;
            foreach(int x in tomb1)
            {
                if (x == keresett) db++;
            }
            Console.WriteLine($"{db} darb({keresett})");
        } 
        static void MasodiLKulom(int[] tomb1)
        {
            List<int> egyedi = new List<int>();

            foreach (int x in tomb1)
            {
                if (!egyedi.Contains(x))
                {
                    egyedi.Add(x);
                }
                
            }
            if (egyedi.Count > 1)
            {
                egyedi.Remove(egyedi.Max());
                Console.WriteLine($"A második legnagyob külömböző érték {egyedi.Max()}");
            }
            else
            {
                Console.WriteLine("Nincs két külömböző zsám a táblában.");
            }

        }
        static void Ismetles(int[] tomb1)
        {
            List<int> egyedi = new List<int>();
            bool ismetles = false;
            foreach (int x in tomb1)
            {
                
                if (!egyedi.Contains(x))
                {
                    egyedi.Add(x);
                }
                else
                {
                    ismetles = true;
                }
            }
            Console.WriteLine(ismetles ? "Van ismétlés" : "Nincs ismétles");
        }
        static int[] Harom(int[] tomb1)
        {
            List<int>harommal = new List<int>();
            foreach (int x in tomb1)
            {
                if (x % 3 == 0) harommal.Add(x);
            }
            int[] tomb3 = new int[harommal.Count()];
            for (int i = 0; i < harommal.Count(); i++ )
            {
                tomb3[i] = harommal[i];
            }
            foreach (int x in tomb3)
            {
                Console.Write($"{x}, ");
            }
            Console.WriteLine();
            return tomb3;
        }
        static int[] Buble(int[] tomb1)
        {
            int[] sorted = new int[tomb1.Length];
            List<int> Transfersd = new List<int>();
            foreach(int x in tomb1)
            {
                Transfersd.Add(x);
            }
            for(int i = 0; i < tomb1.Length; i++)
            {
                sorted[i] = Transfersd.Max();
                Transfersd.Remove(Transfersd.Max());
            }
            foreach (int x in sorted)
            {
                Console.Write($"{x}, ");
            }
            Console.WriteLine();
            return sorted;
        }
        static void Main(string[] args)
        {
            bool run = true;
            while(run)
            {
                try
                {
                    int[] tomb1 = { 1, 3, 4, -6, 9, 0, 50, 60, 74, 12, 45, 23, 4};
                    Console.WriteLine($"A tömb első eleme {tomb1[0]}, a harmadik {tomb1[2]}, a hosszam {tomb1.Length}");
                    Console.WriteLine();

                    int[] tomb2 = new int[5];
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"Kérlek add meg a tömb következő elemét({i}): ");
                        tomb2[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    foreach (int x in tomb2)
                    {
                        Console.Write($"{x}, ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    for (int i = tomb1.Length - 1;i > -1; i--)
                    {
                        Console.Write($"{tomb1[i]}, ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    for (int i = 0; i < tomb1.Length; i++)
                    {
                        string p = tomb1[i] % 2 == 0 ? "Páros" : "Páratlan";
                        Console.Write($"{tomb1[i]} {p} , ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    for (int i = 0; i < tomb1.Length; i++)
                    {
                        Console.Write($"{tomb1[i]*10} , ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    if (tomb1.Length != 0)
                    {
                        int sum = 0;
                        for (int i = 0; i < tomb1.Length; i++)
                        {
                            sum += tomb1[1];
                        }
                        int atlag = sum / tomb1.Length;
                        Console.WriteLine($" összeg {sum}, átlag {atlag}");
                    }
                    Console.WriteLine();

                    int db = 0;
                    for (int i = 0; i < tomb1.Length; i++)
                    {
                        if (tomb1[i] %2 == 0) db++;
                    }
                    Console.WriteLine($"{db} darab");
                    Console.WriteLine();

                    int min = tomb1[0];
                    int max = tomb1[0]; 
                    if (tomb1.Length != 0)
                    {
                        for (int i = 0; i < tomb1.Length; i++)
                        {
                            if (min > tomb1[i]) min = tomb1[i];
                            if (max < tomb1[i]) max = tomb1[i];
                        }
                        Console.WriteLine($"min {min}, max {max}");
                    }
                    else Console.WriteLine("Üres a tömb nincsenek értékek.");
                    Console.WriteLine();

                    keresettElso(tomb1,4);
                    Console.WriteLine();
                    keresettUtolso(tomb1,4);
                    Console.WriteLine();
                    Felett(tomb1);
                    Console.WriteLine();
                    Darab(tomb1, 4);
                    Console.WriteLine();

                    foreach (int x in tomb1)
                    {
                        Console.Write($"{x}, ");
                    }
                    Console.WriteLine();
                    int leso = tomb1[0];
                    int utolso = tomb1[tomb1.Length - 1];
                    tomb1[0] = utolso;
                    tomb1[tomb1.Length - 1] = leso;
                    foreach (int x in tomb1)
                    {
                        Console.Write($"{x}, ");
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    MasodiLKulom(tomb1);
                    Console.WriteLine();

                    Ismetles(tomb1);
                    Console.WriteLine();

                    int[] tomb3 = Harom(tomb1);
                    Console.WriteLine();

                    tomb1 = Buble(tomb1);

                    Console.ReadLine();
                    run= false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(" Rossz formátum próbáld ujra");
                    Console.ReadLine();
                }
            }
            
            
        }
    }
}
