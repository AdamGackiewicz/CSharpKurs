using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Program
    {
        private static int age;
        private static string name;

        static void Main(string[] args)
        {
            //instrictionIf();
            Console.WriteLine("Podaj imie:");
            name = Console.ReadLine();

            switch (name)
            {
                case "Marcin":
                    Metoda1();
                    break;
                case "Tomek":
                    Metoda2();
                    Metoda3();
                    break;
                case "Ania":
                    Metoda1();
                    Metoda2();
                    Metoda3();
                    Metoda4();
                    break;
                default:
                    Metoda4();
                    break;
            }
            Console.ReadKey();
        }

        private static void instrictionIf()
        {
            Console.WriteLine("Podaj swój wiek");
            age = int.Parse(Console.ReadLine());

            String test = age > 18 ? "Pełnoletni" : "Dziecko";
            Console.WriteLine(test);

            Console.WriteLine("Podaj swoje imie");
            name = Console.ReadLine();
            if (age <= 10)
            {
                if (name == "Marcin")
                {
                    Metoda1();
                }


            }
            else if (age < 20)
            {
                Metoda2();
            }
            else if (age < 30)
            {
                Metoda3();
            }
            else
            {
                Metoda4();
            }
        }

        private static void Metoda4()
        {
            Console.WriteLine("Jesteś w metodzie 4");
        }

        private static void Metoda3()
        {
            Console.WriteLine("Jesteś w metodzie 3");
        }

        private static void Metoda2()
        {
            Console.WriteLine("Jesteś w metodzie 2");
        }

        private static void Metoda1()
        {
            Console.WriteLine("Jesteś w metodzie 1");
        }
    }
}
