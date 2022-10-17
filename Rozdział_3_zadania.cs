using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozdział3_Zadania
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
            int rok;
            Console.WriteLine("Podaj rok:");
            rok = int.Parse(Console.ReadLine());

            if((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
            {
                Console.WriteLine("Rok {0} jest przestępny.", rok);
            }
            else
            {
                Console.WriteLine("Rok {0} nie jest przestępny.", rok);
            }
        }
        static void Zadanie_2()
        {
            int a, b;
            Console.WriteLine("Podaj 2 liczby całkowite:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if(a % b == 0)
            {
                Console.WriteLine("Liczba {0} jest dzielnikiem {1}", b, a);
            }
            else
            {
                Console.WriteLine("Liczba {0} nie jest dzielnikiem {1}", b, a);
            }
        }
        static void Zadanie_3()
        {
            double a, b, c, max;
            Console.WriteLine("Podaj 3 liczby:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            max = Math.Max(a, Math.Max(b, c));
            
            Console.WriteLine("Największa liczba z podanych to: {0}", max);
        }
        static void Zadanie_4()
        {
            double a, b;
            char znak;
            Console.WriteLine("Podaj 2 liczby:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj znak operacji [ + lub - lub * lub / ]:");
            znak = char.Parse(Console.ReadLine());

            switch (znak)
            {
                case '+':
                    Console.WriteLine("{0} {1} {2} = {3}", a, znak, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0} {1} {2} = {3}", a, znak, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0} {1} {2} = {3}", a, znak, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("{0} {1} {2} = {3}", a, znak, b, a / b);
                    break;
                default:
                    Console.WriteLine("Nieznany znak.");
                    break;
            }
        }
        static void Zadanie_5()
        {
            double a, b, c, delta;
            Console.WriteLine("Podaj wartość A, B, C:");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2) - 4 * a * c;

            if(delta < 0)
            {
                Console.WriteLine("Brak pierwiastków");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Pierwiastkiem równania jest: {0}", x);
            }
            else
            {
                double x1, x2;
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Pierwiastkami równania są: {0} i {1}", x1, x2);
            }
        }
        static void Zadanie_6()
        {
            double waga, wzrost, bmi;
            Console.WriteLine("Podaj wagę w [kg] i wzrost w [m]: ");
            waga = double.Parse(Console.ReadLine());
            wzrost = double.Parse(Console.ReadLine());
            bmi = waga / Math.Pow(wzrost, 2);
           
            if(bmi < 18.5)
            {
                Console.WriteLine("BMI wynosi {0} - nideowaga", bmi);
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("BMI wynosi {0} - wartość prawidłowa", bmi);
            }
            else
            {
                Console.WriteLine("BMI wynosi {0} - nadwaga", bmi);
            }
        }
        static void Zadanie_7()
        {
            Console.WriteLine("Wpisz nr dnia tygodnia");
            string numer = Console.ReadLine();
            switch (numer)
            {
                case "1":
                    Console.WriteLine("Poniedziałek");
                    break;
                case "2":
                    Console.WriteLine("Wtorek");
                    break;
                case "3":
                    Console.WriteLine("Środa");
                    break;
                case "4":
                    Console.WriteLine("Czwartek");
                    break;
                case "5":
                    Console.WriteLine("Piątek");
                    break;
                case "6":
                    Console.WriteLine("Sobota");
                    break;
                case "7":
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia");
                    break;
            }
            Console.ReadKey();
        }
        static void Zadanie_8()
        {
            Console.WriteLine("Podaj wartość średniej ocen:");
            double srednia = double.Parse(Console.ReadLine());

            if(srednia >= 2 && srednia < 4)
            {
                Console.WriteLine("Kwota stypendium wynosi: 0,00 zł");
            }
            else if (srednia >= 4 && srednia < 4.8)
            {
                Console.WriteLine("Kwota stypendium wynosi: 350,00 zł");
            }
            else if (srednia >= 4.8 && srednia < 5)
            {
                Console.WriteLine("Kwota stypendium wynosi: 550,00 zł");
            }
        }
        static void Zadanie_9()
        {
            Console.WriteLine("Podaj wariant: [ a, b, c, d ]");
            char wariant = char.Parse(Console.ReadLine());

            switch (wariant)
            {
                case 'a':
                    Console.WriteLine("Podaj liczbę wierszy:");
                    int rows_a = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= rows_a; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    break;
                case 'b':
                    Console.WriteLine("Podaj liczbę wierszy:");
                    int rows_b = int.Parse(Console.ReadLine());

                    for (int i = rows_b; i > 0; i--)
                    {
                        for (int j = i; j > 0; j--)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    break;
                case 'c':
                    Console.WriteLine("Podaj liczbę wierszy:");
                    int rows_c = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= rows_c; i++)
                    {
                        for (int j = 1; j <= rows_c; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    break;
                case 'd':
                    Console.WriteLine("Podaj liczbę wierszy:");
                    int rows_d = int.Parse(Console.ReadLine());

                    for (int i = 0; i < rows_d; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                    for (int j = 1; j < rows_d - 1; j++)
                    {
                        for (int i = 0; i < rows_d; i++)
                        {
                            if (i == 0 || i == rows_d - 1)
                                Console.Write("*");
                            else
                                Console.Write(" ");
                        }
                        Console.WriteLine("");
                    }
                    for (int i = 0; i < rows_d; i++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("\n");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego wariantu.");
                    break;
            }
        }
        static void Zadanie_10()
        {
            int n, silnia = 1;
            Console.WriteLine("Podaj liczbę:");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                silnia *= i;
            }
            Console.WriteLine("{0}! = {1}", n, silnia);
        }
        static void Zadanie_11()
        {
            int suma = 0, ilosc = 0;
            for(int i = 1; suma < 101; i++)
            {
                suma += i;
                ilosc++;
            }
            Console.WriteLine("Suma: {0}, Ilość: {1}", suma, ilosc);
        }
        static void Zadanie_12()
        {
            int n, suma = 0;
            Console.WriteLine("Podaj liczby całkowite różne od 0:");
            while ((n = int.Parse(Console.ReadLine())) != 0)
            {
                suma += n;
            }
            Console.WriteLine("Suma wprowadzonych liczb wynosi: {0}", suma);
        }
        static void Zadanie_13()
        {
            int n, suma = 0;
            Console.WriteLine("Podaj liczbę:");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                suma += (int)Math.Pow(-1, i + 1) * i;
            }
            Console.WriteLine("Suma szeregu {0} wyrazowego wynosi: {1}", n, suma);
        }
        static void Zadanie_14()
        {
            Console.WriteLine("Podaj liczbę: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int suma = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        suma += j;
                    }
                }
                if (suma == i)
                    Console.WriteLine("Liczba {0} jest liczbą doskonałą", i);
            }
        }
        static void Zadanie_15()
        {
            for (int z1 = 0; z1 <= 10; z1++)
            {
                for (int z2 = 0; z2 <= 5; z2++)
                {
                    for (int z5 = 0; z5 <= 2; z5++)
                    {
                        if (z1 * 1 + z2 * 2 + z5 * 5 == 10)
                        {
                            Console.WriteLine("1 zł = {0} | 2 zł = {1} | 5 zł = {2}", z1, z2, z5);
                        }
                    }
                }
            }
        }
    }
}
