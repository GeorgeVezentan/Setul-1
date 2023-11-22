using System;

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Probleme
{
    internal class Program
    {
        private static object copy;

        static void Main(string[] args)
        {
            //P1();
            //P2();
            //P3();
            //P4();
            //P5();
            //P6();
            //P7();
            //P8();
            //P9();
            //P10();
            //P11();
            //P12();
            //P13();
            //P14();
            //P15();
            //P16();
            //P17();
            //P18();
            //P19();
            //P20();
            P21();
        }

        private static void P21()
        {
            Console.WriteLine("Alegeti un numar între 1 si 1024 inclusiv.");
            Console.WriteLine("Raspundeti cu 'da' sau 'nu' la întrebarile urmatoare.");

            int guess = 512; // Presupunem initial ca numarul este la jumatatea intervalului

            while (true)
            {
                Console.WriteLine($"Numarul este mai mare sau egal decat {guess}? (da/nu)");
                string raspuns = Console.ReadLine().ToLower();

                if (raspuns == "da")
                {
                    Console.WriteLine($"Numarul este: {guess}");
                    break;
                }
                else if (raspuns == "nu")
                {
                    Console.WriteLine("Numarul este mai mic.");
                    guess = guess / 2; // Ghicim din nou la jumatatea intervalului ramas
                }
                else
                {
                    Console.WriteLine("Raspuns invalid. Va rugam sa raspundeti cu 'da' sau 'nu'.");
                }

            }
        }
        private static void P20()
        {
           


        }

        private static void P19()
        {
            Console.WriteLine("Introduceți un număr pentru verificare:");
            int numar = Convert.ToInt32(Console.ReadLine());

            bool areDoar2CifreRepetate = VerificaCifre(numar);

            if (areDoar2CifreRepetate)
            {
                Console.WriteLine($"Numărul {numar} este format doar din 2 cifre care se pot repeta.");
            }
            else
            {
                Console.WriteLine($"Numărul {numar} nu este format doar din 2 cifre care se pot repeta.");
            }
        }

        static bool VerificaCifre(int numar)
        {
            var cifreDistincte = numar.ToString().Distinct().ToList();

            return cifreDistincte.Count == 2;

        }

        private static void P18()
        {
            Console.WriteLine("Introduceti un numar");
            int numar = int.Parse(Console.ReadLine());
            Console.Write("Rezultatul este: ");
            for (int factor = 2; factor <= numar; factor++)
            {
                int exponent = 0;
                while (numar % factor == 0)
                {
                    exponent++;
                    numar /= factor;
                }
                if (exponent > 0)
                    Console.Write($"{factor}^{exponent}");
                if (numar > 1)
                    Console.Write("x");   
            }
            Console.WriteLine("");
        }

        private static void P17()
        {
            Console.WriteLine("Introduceti 2 numere:");
            int numar1 = int.Parse(Console.ReadLine());
            int numar2 = int.Parse(Console.ReadLine());

            int a = numar1;
            int b = numar2;
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            int cmmd = a;
            int cmm = (numar1 * numar2) / cmmd;
            Console.WriteLine($"CMMD = {cmmd}");
            Console.WriteLine($"CMM = {cmm}");
        }

        private static void P16()
        {
            Console.Write("Introduceti primul numar: ");
            double numar1 = double.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea numar: ");
            double numar2 = double.Parse(Console.ReadLine());

            Console.Write("Introduceti al treilea numar: ");
            double numar3 = double.Parse(Console.ReadLine());

            double celMaiMic, mijloc, celMaiMare;

            if (numar1 <= numar2 && numar1 <= numar3)
            {
                celMaiMic = numar1;
                if (numar2 <= numar3)
                {
                    mijloc = numar2;
                    celMaiMare = numar3;
                }
                else
                {
                    mijloc = numar3;
                    celMaiMare = numar2;
                }
            }
            else if (numar2 <= numar1 && numar2 <= numar3)
            {
                celMaiMic = numar2;
                if (numar1 <= numar3)
                {
                    mijloc = numar1;
                    celMaiMare = numar3;
                }
                else
                {
                    mijloc = numar3;
                    celMaiMare = numar1;
                }
            }
            else
            {
                celMaiMic = numar3;
                if (numar1 <= numar2)
                {
                    mijloc = numar1;
                    celMaiMare = numar2;
                }
                else
                {
                    mijloc = numar2;
                    celMaiMare = numar1;
                }
            }Console.WriteLine($"Numerele în ordine crescătoare sunt: {celMaiMic}, {mijloc}, {celMaiMare}");


        }
        
        private static void P15()
        {
            Console.WriteLine("Introduceti 3 numere");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());  
            int c = int.Parse(Console.ReadLine());

            int[] numere = { a , b, c };
            Array.Sort(numere);
            Console.WriteLine($"Numerele sortate sunt");
            foreach (var numar in numere)
            {
                Console.WriteLine(numar + " ");
            }
        }

        private static void P14()
        {
            Console.WriteLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            int b = 0;
            copy = n;
        
            while (n != 0)
            {
                b = b * 10 + n % 10;
                n = n / 10;
                b = n;
            } Console.WriteLine($"{b}"); 
            if (b == n)
            {
                Console.WriteLine("Numarul este palindrom");
            }
            else
            {
                Console.WriteLine("Nuamrul nu este palindrom");
            }
        }

        private static void P13()
        {
            Console.WriteLine("Introduceti un interval de ani");
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            int anibisecti = 0;
            
            for (int an = y1; an <= y2; an++)
            {
                if ((an % 4 == 0 && an % 100 != 0) || (an % 400 == 0))
                {
                    anibisecti++;
                    Console.WriteLine($"{an} este an bisect");
                }
            }
            Console.WriteLine($"Între anii {y1} și {y2} sunt {anibisecti} ani bisecți.");
        }

        private static void P12()
        {
            Console.WriteLine("Introdu un numar a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu un numar b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introdu numarul care sa se divida cu numerele din intervalul [{a} {b}]");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    count++;
                }
            }Console.WriteLine($"Numarul de numere divizibile cu {n} pe intervalul [{a} {b}] este: {count}");
        } 

        private static void P11()
        {
            Console.WriteLine("Introduceti un numar");
            int n = int.Parse(Console.ReadLine());
            int cif = 0;
            while (n != 0)
            {
                cif = cif * 10 + n % 10;
                n = n / 10;
            }
            Console.WriteLine($"Inversul numarului este {cif}");
        }

        private static void P10()
        {
            Console.WriteLine("Introduceti un numar:");
            int n = int.Parse(Console.ReadLine());
            int d = 1;
            int s = 0;
            for (d = 1; d <= n; d++)
            {
                if (n % d == 0)
                {
                    s = s + d;
                }
            }
            if ( s == 1 + n)
            {
                Console.WriteLine("Numarul este prim");
            }
            else
            {
                Console.WriteLine("Numarul nu este prim");
            }
        }

        private static void P9()
        {
            Console.WriteLine("Introduceti un numar:");
            float n = float.Parse(Console.ReadLine());
            float d = 1;
            for (d = 1; d <= n; d++)
            {
                if (n % d == 0)
                {
                    Console.WriteLine($"Divizorul numarului este {d}");
                }
            }


        }

        private static void P8()
        {
            Console.WriteLine("Introduceti numarul a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("introduceti un numar b");
            double b = double.Parse(Console.ReadLine());
            
            

            Console.WriteLine($"Numarul a este: {b} ");
            Console.WriteLine($"Numarul b este: {a}");
        }

        private static void P7()
        {
            Console.WriteLine("Introduceti numarul a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("introduceti un numar b");
            double b = double.Parse(Console.ReadLine());
            double c = 0;
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"Numarul a este: {a} ");
            Console.WriteLine($"Numarul b este: {b}");


        }

        private static void P6()
        {
            Console.WriteLine("Introduceti valoarea lui a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui c");
            double c = double.Parse(Console.ReadLine());    

            if (a + b >= c)
            {
                Console.WriteLine("a, b si c sunt lungimile laturilor unui triunghi deoarece a+b>=c");
            }
            if (b + c >= a)
            {
                Console.WriteLine("a, b si c sunt lungimile laturilor unui triunghi deoarece b+c>=a");
            }
            if (a + c >= b)
            {
                Console.WriteLine("a, b si c sunt lungimile laturilor unui triunghi deoarece a+c>=b");
            }
            else
            {
                Console.WriteLine("a, b si c nu pot fi lungimile laturilor unui triunghi deoarece l1+l2<=l3");
            }
        }

        private static void P5()
        {
            Console.WriteLine("introduceti un numar:");
            string n = Console.ReadLine();
            Console.WriteLine("Introduceti pozitia lui k");
            int k = int.Parse(Console.ReadLine());
            if (k >= 1 && k <= n.Length)
            {
                char cif = n[n.Length - k];
                Console.WriteLine($"Rezultatul este {cif}");

            }
            else
                Console.WriteLine("Valoarea lui k nu este corespunzatoare");
        }

        private static void P4()
        {
            Console.WriteLine("Introduceti un an");
            double an = double.Parse(Console.ReadLine());

            if ((an % 4 == 0 && an % 100 != 0) || (an % 400 == 0))
            {
                Console.WriteLine($"Anul { an } este bisect.");
            }
            else
            {
                Console.WriteLine($"Anul {an} nu este bisect.");
            }

        }

        private static void P3()
        {
            Console.WriteLine("Introduceti 2 numere");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (n % k == 0)
            {
                Console.WriteLine($"{n} divide pe {k}");
            }
            else
            {
                Console.WriteLine($"{n} nu divide pe {k}"); 
            }
        }

        private static void P2()
        {
            Console.WriteLine("Ecuatia de gradul 2");
            Console.WriteLine("Introduceti 3 numere");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double delta = (b * b) - (4 * a * c);
            double x1 = (b * (-1) + (Math.Sqrt(delta))) / (2 * a);
            double x2 = (b * (-1) - (Math.Sqrt(delta))) / (2 * a);

            if (delta > 0)
            {
                Console.WriteLine("Ecuatia are 2 solutii diferite");
                Console.WriteLine($"x1= {x1}");
                Console.WriteLine($"x2= {x2}");

            }
            if (delta < 0)
            {
                Console.WriteLine("Ecuatia nu are solutii");
            }
            if (delta  == 0)
            {
                Console.WriteLine("Ecuatia are 2 solutii egale");
                Console.WriteLine($"{x1} = {x2}");
            }
                
        }

        private static void P1()
        {
            {
                Console.WriteLine("Introduceti valoarea lui a");

                double a = Double.Parse(Console.ReadLine());

                Console.WriteLine("Introduceti valoarea lui b");
                double b = Double.Parse(Console.ReadLine());
                //Verificati daca ecuatia are o solutie
                if (a == 0)
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Ecuatia are o infinitate de solutii");

                    }
                    else
                    {
                        Console.WriteLine("Ecuatia nu are solutie");
                    }
                }
                else
                {
                    double x = -b / a;

                    Console.WriteLine(" Solutia ecuatiei " + a + " x + " + b + " = 0 este x = " + x);
                }
            }
        }
    }
}
