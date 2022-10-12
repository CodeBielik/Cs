using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdział2_Zadania
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
            //Zadanie_9a();
            //Zadanie_9b();
            //Zadanie_9c();
            //Zadanie_9d();
            //Zadanie_9e();
            //Zadanie_9f();
            //Zadanie_10();
        }
        static void Zadanie_1()
        {
            double C, F;
            Console.WriteLine("Podaj temp. w celsjuszach: ");
            C = double.Parse(Console.ReadLine());
            F = 32.0 + (9 * C) / 5;
            Console.WriteLine(C + "*C jest równa " + F + "*F");
        }
        static void Zadanie_2()
        {
            double a, b, c, delta;
            Console.WriteLine("Podaj współczynniki A, B i C: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            delta = Math.Pow(b, 2) -4 * a * c;
            Console.WriteLine("Delat wyrażenia {0}x^2 + {1}x + {2} = 0 wynosi: {3}", a, b, c, delta);
        }
        static void Zadanie_3()
        {
            double waga, wzrost;
            Console.WriteLine("Podaj wagę w [kg] i wzrost w [m]: ");
            waga = double.Parse(Console.ReadLine());
            wzrost = double.Parse(Console.ReadLine());
            Console.WriteLine("BMI wynosi: " + waga / Math.Pow(wzrost, 2));
        }
        static void Zadanie_4()
        {
            //a
            int x = 100;
            Console.WriteLine(++x * 2);
        }
        static void Zadanie_6()
        {
            //3
            int x, y = 4;
            x = (y -= 2);
            x = y++;
            x = y--;
            Console.WriteLine(x);
        }
        static void Zadanie_7()
        {
            //7
            int x, y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(++y);
        }
        static void Zadanie_8()
        {
            //true
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine(x);
        }
        static void Zadanie_9a()
        {
            //false x=2 y=4 z=2
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        }
        static void Zadanie_9b()
        {
            //false x=2 y=5 z=2
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        }
        static void Zadanie_9c()
        {
            //false x=2 y=5 z=1
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        }
        static void Zadanie_9d()
        {
            //true x=1 y=3 z=4
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 || y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        }
        static void Zadanie_9e()
        {
            //true x=1 y=4 z=4
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        }
        static void Zadanie_9f()
        {
            //true x=1 y=4 z=5
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        }
        static void Zadanie_10()
        {
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (double)osoby / (double)powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
        }
    }
}
