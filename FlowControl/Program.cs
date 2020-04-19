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
            Console.WriteLine("Podaj swój wiek");
            age = int.Parse(Console.ReadLine());

            String test = age > 18 ? "Pełnoletni" : "Dziecko";
            Console.WriteLine(test);

            //Console.WriteLine("Podaj swoje imie");
            //name = Console.ReadLine();
            //if (age <= 10)
            //{
            //    if (name == "Marcin")
            //    {
            //        Metoda1();
            //    }


            //}
            //else if (age < 20)
            //{
            //    Metoda2();
            //}
            //else if (age < 30)
            //{
            //    Metoda3(); 
            //}
            //else
            //{
            //    Metoda4();
            //}
            Console.ReadKey();
        }

        private static void Metoda4()
        {
            Console.WriteLine("masz 30 lub więcej lat");
        }

        private static void Metoda3()
        {
            Console.WriteLine("twój wiek jest większy lub równy 20 a mniejszy niż 30 i wynosi" + age);
        }

        private static void Metoda2()
        {
            Console.WriteLine("Twój wiek jwest większy od 10 a niejszy od 20 i wynosi " + age);
        }

        private static void Metoda1()
        {
            Console.WriteLine("Masz 10 lub mniej lat a dokładnie masz "+ age);
        }
    }
}
