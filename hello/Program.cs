using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
        //    valueTypes();

            for (;;)
            {
                Greeting();
                Age();
                Settings();
            }
        }

        //private static void valueTypes()
        //{
        //    int maxInt = int.MaxValue;
        //    int minInt = int.MinValue;
        //    long maxLong = long.MaxValue;
        //    long minLong = long.MinValue;

        //    Console.WriteLine("maxInt = " + maxInt);
        //    Console.WriteLine("minInt = " + minInt);
        //    Console.WriteLine("maxLong = " + maxLong);
        //    Console.WriteLine("minLong = " + minLong);
        //}

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Wypisujemy komunikat zależny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("Wpisz ile masz lat: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);


            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Brawo. Jesteś pełnoletni, możesz wypić Browara!");
            }
            else if (result == false)
            {
                Console.WriteLine("Wprowadziłeś niepoprawny wiek!");
            }
            else
            {
                Console.WriteLine("Możemy ci zaoferować Mleko");
            }
        }
        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);
        }
    }
}
