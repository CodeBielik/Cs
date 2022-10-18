using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdział4_Zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie_1();
            //Zadanie_2();
            //Zadanie_3();
            //Zadanie_4();
            //Zadanie_5();
            //Zadanie_6();
            //Zadanie_7();
            //Zadanie_8();
            //Zadanie_9();
            //Zadanie_10();
            //Zadanie_11();
            //Zadanie_12();
            //Zadanie_13();
            //Zadanie_14();
            //Zadanie_15();
        }
        static void Zadanie_1()
        {
            Console.WriteLine("Podaj liczbę elementów tablicy:");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];

            Console.WriteLine("Podaj liczby:");
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Liczby w tablicy:");
            foreach(int i in tab)
            {
                Console.Write("{0,2}", i);
            }
            Console.WriteLine("");
        }
        static void Zadanie_2()
        {
            int[] tab1 = { -5, -2, 0, 4, 6, 9, 1, 2, 8, -20};
            int[] tab2 = new int[tab1.Length];
            
            for (int i = 0; i < tab1.Length; i++)
            {
                if(tab1[i] > 0)
                {
                    tab2[i] = tab1[i];
                }
            }
            Console.Write("Elementy dodatnie w tablicy: ");
            foreach (int i in tab2)
            {
                Console.Write("{0,2}", i);
            }
            Console.WriteLine("");
        }
        static void Zadanie_3()
        {
            Console.WriteLine("Podaj liczbę elementów tablicy:");
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int[n];

            Console.WriteLine("Podaj liczby:");
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }

            int max = tab.Max();
            int index = Array.IndexOf(tab, max);

            Console.WriteLine("Największa wartość wynosi: {0}, indeks tej wartości to: {1}", max, index);

            int min = tab.Min();
            index = Array.IndexOf(tab, min);

            Console.WriteLine("Najmniejsza wartość wynosi: {0}, indeks tej wartości to: {1}", min, index);

            double avg = tab.Average();

            Console.WriteLine("Średnia wartośći wszystkich elementów tablicy wynosi: {0}", avg);

            int positive = tab.Where(x => x > 0).Count();
            Console.WriteLine("Liczba dodatnich elementów tablicy wynosi: {0}", positive);
        }
        static void Zadanie_4()
        {
            bool czyPierwsza(int n)
            {
                if(n <= 1)
                {
                    return false;
                }

                for(int i = 2; i <= n / 2; i++)
                {
                    if(n % i == 0)
                    {
                        return false;
                    }
                    
                }
                return true;
            }

            Random rand = new Random();

            int licznik = 0;
            int[] tab = new int[100];

            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = rand.Next(1, 1000);
            }

            foreach (int i in tab)
            {
                Console.Write("{0,6}", i);
            }
            Console.WriteLine("\n");

            for (int i = 0; i < tab.Length; i++)
            {
                if (czyPierwsza(tab[i]))
                {
                    licznik++;
                    Console.Write("{0,6}", tab[i]);
                }
            }
            Console.WriteLine("\nWszystkich liczb pierwszych w tej tablicy jest: {0}", licznik);
        }
        static void Zadanie_5()
        {
            int[] tab1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] tab2 = new int[tab1.Length];

            Array.Copy(tab1, 0, tab2, 1, 9);
            Array.Copy(tab1, 9, tab2, 0, 1);
            
            Console.Write("Elementy tablicy 2: ");
            foreach (int i in tab2)
            {
                Console.Write("{0,2}", i);
            }
            Console.WriteLine("");
        }
        static void Zadanie_6()
        {
            Random rand = new Random();
            double[,] tab = new double[5, 5];
            double suma = 0;
            
            for(int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = rand.Next(1, 10);
                }
            }

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("{0} ", tab[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for(int i = 0; i < tab.GetLength(0); i++)
            {
                suma += tab[i, i];
            }

            Console.WriteLine("Suma elementów na głównej przekątnej wynosi: {0}", suma);
        }
        static void Zadanie_7()
        {
            int[,] A = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] B = { { 10, 11, 12 }, { 13, 14, 15 } };

            int[,] C = new int[2, 3];

            Console.WriteLine("Tab 'A'\n");

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write("{0,3}", A[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Tab 'B'\n");

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write("{0,4}", B[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Suma macierzy:\n");

            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                    Console.Write("{0,4}", C[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Zadanie_8()
        {
            string[,] dniTygodnia = new string[7,3];
            string[] polskie = new string[] { "poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "sobota", "niedziela"};
            string[] angielskie = new string[] { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday"};
            string[] niemieckie = new string[] { "montag", "dienstag", "mittwoch", "donnerstag", "freitag", "samstag", "sonntag"};

            for (int i = 0, j = 0, k = 1, l = 2; i < dniTygodnia.GetLength(0); i++)
            {
                dniTygodnia[i, j] = polskie[i];
                dniTygodnia[i, k] = angielskie[i];
                dniTygodnia[i, l] = niemieckie[i];
            }

            for (int i = 0; i < dniTygodnia.GetLength(0); i++)
            {
                for(int j = 0; j < dniTygodnia.GetLength(1); j++)
                {
                    Console.Write("{0,15}", dniTygodnia[i,j]);
                }
                Console.WriteLine();
            }
        }
        static void Zadanie_9()
        {
            Console.WriteLine("Podaj łańcuch znaków:");
            string lancuch = Console.ReadLine();

            string[] wyrazy = lancuch.Split(' ');

            Console.WriteLine("Liczba wyrazów w tym łańcuchu wynosi: {0}", wyrazy.Length);
            
        }
        static void Zadanie_10()
        {
            DateTime dt = DateTime.Today;
            Console.WriteLine(dt.ToString("dd/MM/yyyy"));
            Console.WriteLine(dt.ToString("MMMM"));
        }
        static void Zadanie_11()
        {
            Console.WriteLine("Podaj łańcuch znaków:");
            string lancuch = Console.ReadLine();

            var charArray = lancuch.ToCharArray().Distinct().ToArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                int suma = lancuch.ToCharArray().Count(x => x == charArray[i]);
                Console.WriteLine("{0} - {1}", charArray[i], suma);
            }
        }
        static void Zadanie_12()
        {
            string tekst = "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
                "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
                "To uczucie dziwnego przygnębienia miewał już nie raz i wiedział,\n" +
                "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
                "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalał.";
            Console.WriteLine(tekst);

            int licznik = 1;
            int start = 0;

            while ((start = tekst.IndexOf('\n', start + 1)) >= 0)
            {
                licznik++;
            }
            Console.WriteLine("\nLiczba wierszy w tekście: {0}", licznik);
            Console.WriteLine();

            string[] podzial = tekst.Split('\n');
            for (int i = 0; i < podzial.Length; i++)
            {
                Console.WriteLine("W wierszu '{0}', mamy {1} znaków.", podzial[i], podzial[i].Length);
                Console.WriteLine();
            }
            Console.WriteLine("\nIlość znaków w całym tekście: {0}", tekst.Length);
        }
        static void Zadanie_13()
        {
            string text = "Kiedy idzie się po miód z balonikiem, to trzeba się starać, żeby pszczoły nie wiedziały, po co się idzie – odpowiedział Puchatek";
            string[] tablicaSlow = text.Split();
            int licznik = 1;

            for (int i = 0; i < tablicaSlow.Length; i++)
            {
                for (int j = 0; j < tablicaSlow.Length; j++)
                {
                    if (tablicaSlow[i].Equals(tablicaSlow[j]) == true && j != i)
                    {
                        tablicaSlow[j] = "null";
                        if (tablicaSlow[i] == "null")
                        {
                            licznik -= 2;
                        }
                        licznik++;
                    }
                }
                if (licznik > 0)
                {
                    tablicaSlow[i] = tablicaSlow[i] + " - " + licznik + " razy";
                }
                licznik = 1;
            }

            Console.WriteLine(text);
            Console.WriteLine();

            foreach (var i in tablicaSlow.Distinct())
            {
                if (i != "null")
                {
                    Console.WriteLine(i);
                }
                licznik++;
            }
        }
        static void Zadanie_14()
        {
            string[] tab = { "lodówka-2010", "laptop-2018", "konsola-2020", "pralka-2005", "ekspres-2022" };

            for (int i = 0; i < tab.Length; i++)
            {
                string[] subs = tab[i].Split('-');
                Console.WriteLine($"Dla produktu: {subs[0]}");

                int rok = DateTime.Now.Year - Convert.ToDateTime($"1/1/{subs[1]}").Year;
                string napis = (rok <= 1) ?
                                 ((rok == 0) ? "nie uplynol jeszcze rok" : "uplynol rok") :
                                 (rok < 5) ? $"uplynely {rok} lata" : $"uplynelo {rok} lat";

                Console.WriteLine($"Od daty zakupu {napis}\n");
            }
        }
        static void Zadanie_15()
        {
            Console.WriteLine("Podaj tekst do zaszyfrowania: ");
            string tekst = Console.ReadLine();
            string szyfr = "GADERYPOLUKI";
            string tekstSzyfr = String.Empty;
            tekst = tekst.ToUpper();
            for (int a = 0; a < tekst.Length; a++)
            {
                for (int b = 0; b < szyfr.Length; b++)
                {
                    if (tekst[a] == szyfr[b])
                    {
                        if (b % 2 == 0)
                        {
                            tekstSzyfr += szyfr[b + 1];
                        }
                        else
                        {
                            tekstSzyfr += szyfr[b - 1];
                        }
                    }
                }
                if (tekstSzyfr.Length - a == 0)
                {
                    tekstSzyfr += tekst[a];
                }
            }
            Console.WriteLine(tekstSzyfr);
        }
    }
}
