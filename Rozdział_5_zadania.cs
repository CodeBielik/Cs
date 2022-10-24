using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdział5_Zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie_1
            Console.WriteLine("Temperatura w Celsjuszach wynosi: {0:0.00}", Zadanie_1(80));

            //Zadanie_2
            /*
            double a, b, x;
            Console.WriteLine("Podaj liczby rzeczywiste [ a, b, x ]:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            x = double.Parse(Console.ReadLine());
            if(Zadanie_2(a, b, x))
                Console.WriteLine("x należy do przedziału otwartego");
            else
                Console.WriteLine("x nie należy do przedziału otwartego");
            */

            //Zadanie_3
            /*
            double wekX = 3, wekY = 2;
            Console.WriteLine("Podaj współrzędne punktu A(x, y):");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Przesun(ref x, ref y, wekX, wekY);
            */

            //Zadanie_4a
            /*
            int[] tab = new int[] { 1, 4, 6, 8, 2 };
            Console.WriteLine("Podaj liczbę:");
            int n = int.Parse(Console.ReadLine());
            int[] tab2 =  Zadanie_4a(tab, n);
            foreach(int i in tab2)
            {
                Console.Write("{0,4}", i);
            }
            Console.WriteLine();
            */

            //Zadanie_4b
            /*
            int[] tab = new int[] { 1, 4, 6, 8, 2};
            Console.WriteLine("Podaj liczbę:");
            int n = int.Parse(Console.ReadLine());
            Zadanie_4b(tab, n);
            */

            //Zadanie_5
            /*
            Console.WriteLine("Podaj długość, szerokość i znak");
            int dlugosc = int.Parse(Console.ReadLine());
            int szerokosc = int.Parse(Console.ReadLine());
            char znak = char.Parse(Console.ReadLine());
            Zadanie_5(dlugosc, szerokosc, znak);
            Zadanie_5(szerokosc, dlugosc, znak);
            */

            //Zadanie_6
            /*
            string[] tab = new string[] { "ala", "kot", "dom" };
            Console.WriteLine("Podaj liczbę:");
            int n = int.Parse(Console.ReadLine());
            Zadanie_6(tab, n);
            */

            //Zadanie_7
            /*
            Console.WriteLine("Podaj x i n:");
            int x = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik sumy wynosi: {0}", Zadanie_7(x, n));
            */

            //Zadanie_8
            /*
            Console.WriteLine("Podaj liczbę naturalną:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Suma cyfr liczby naturalnej wynosi: {0}", Zadanie_8(x));
            */

            //Zadanie_9rek
            /*
            Console.WriteLine("Podaj liczbę:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Wynik dla F({0}) = {1}", n, Zadanie_9rek(n));
            Console.WriteLine("Wynik dla F({0}) = {1}", n, Zadanie_9ite(n));
            */

            //Zadanie_10: 15
            //Console.WriteLine(Oblicz(5));
        }
        static double Zadanie_1(double F)
        {
            return (5.0 / 9) * (F - 32);
        }
        static bool Zadanie_2(double a, double b, double x)
        {
            if (x > a && x < b) return true;
            else return false;
        }
        //Zadanie_3
        static void Przesun(ref double x, ref double y, double wekX, double wekY)
        {
            Console.WriteLine("Punkt A po przesunięciu o wektor [3, 2] wynosi: ({0}, {1})", (x + wekX), (y + wekY));
        }
        static int[] Zadanie_4a(int[] tab, int n)
        {
            int[] wynik = (int[])tab.Clone();

            for (int i = 0; i < wynik.Length; i++)
            {
                wynik[i] *= n;
            }

            return wynik;
        }
        static void Zadanie_4b(int[] tab, int n)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] *= n;
            }

            foreach (int x in tab)
            {
                Console.Write("{0,4}", x);
            }
            Console.WriteLine();
        }
        static void Zadanie_5(int x, int y, char znak)
        {
            Console.WriteLine();
            for (int i = 0; i < y; i++)
            {
                for(int j = 0; j < x; j++)
                {
                    Console.Write("{0}", znak);
                }
                Console.WriteLine();
            }
        }
        static void Zadanie_6(string[] tab, int n)
        {
            string temp = "";
            for (int i = 0; i < tab.Length; i++)
            {
                temp = tab[i];
                for(int j = 1; j < n; j++)
                {
                    tab[i] += temp;
                }
            }

            foreach (string x in tab)
            {
                Console.Write("{0,4} ", x);
            }
            Console.WriteLine();
        }
        static int Zadanie_7(int x, int n)
        {
            int suma = 0;
            for(int i = 1; i <= n; i++)
            {
                suma += (x + i);
            }
            return suma;
        }
        static int Zadanie_8(int x)
        {
            int wynik = 0;

            while(x != 0)
            {
                wynik += (x % 10);
                x /= 10;
            }
            return wynik;
        }
        static int Zadanie_9rek(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return Zadanie_9rek(n - 1) + Zadanie_9rek(n - 2);
        }
        static int Zadanie_9ite(int n)
        {
            int wynik = 0, x = 1, y = 1;
            for(int i = 0; i < n; i++)
            {
                y = wynik;
                wynik += x;
                x = y;
            }
            return wynik;
        }
        //Zadanie_10
        static int Oblicz(int n)
        {
            if (n <= 1) return 1;
            else return (n + Oblicz(n - 1));
        }
    }
}
