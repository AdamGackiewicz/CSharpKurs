using System;
using System.IO;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(3.5f);
            diary.AddRating(5.4f);
            diary.AddRating(8.4f);

            DiaryStatistics stats = diary.ComputeStatistics();
            // 15.04.2020   blokuje by nie opzszkadzało - nauka o włwaściwościach.
            //WriteResult("Avarage", stats.AverageGrade, 3, 5, 7, 8, 9);
            //WriteResult("Max", (int)stats.MaxGrade);
            //WriteResult("Min", (long)stats.MinGrade);
            //WriteResult("Min", stats.MinGrade, 1);

            
            //Dodajemy delegaty   -  pozniejsza zmiana składni pod event
            diary.NameChengaed += new NameChangedDelegate(OnNameChanged);  //wymanaga składnia przy delegacie
            diary.NameChengaed += OnNameChanged2;  // event delegate ustawia za kulisami - można zredukować składnie
            diary.NameChengaed += OnNameChanged3;
            diary.NameChengaed += OnNameChanged4;
            diary.NameChengaed += OnNameChanged4;
            diary.NameChengaed += OnNameChanged4;
            diary.NameChengaed += null;  //event nie akceptuje zastąpienia zdarzeńpoprzez =null   można dodać +=null (co nic nie zmienia ale składnia akceptowalna)
            diary.NameChengaed -= OnNameChanged4; // możliwe odejmowanie subskrypci przypisanych do evenu
            diary.NameChengaed -= OnNameChanged4;

            diary.Name = "Dzienniczek Marcina";
            diary.Name = "Jacek Hej";
            diary.Name = "";
            diary.Name = null;
            Console.WriteLine(diary.Name);
            Console.ReadLine();

            #region stary kod
            //Diary diary = new Diary();

            //diary.NameChengaed += OnNameChanged;
            //diary.NameChengaed += OnNameChanged2;
            //diary.NameChengaed += OnNameChanged3;
            //diary.NameChengaed += OnNameChanged4;
            //diary.NameChengaed += OnNameChanged4;
            //diary.NameChengaed += OnNameChanged4;
            //diary.NameChengaed += OnNameChanged4;
            //diary.NameChengaed -= OnNameChanged4;
            //diary.NameChengaed -= OnNameChanged4;
            //diary.NameChengaed -= OnNameChanged4;

            //try
            //{
            //    Console.WriteLine("Proszę podaj imie");
            //    diary.Name = Console.ReadLine();
            //}
            //catch (ArgumentException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //catch (NullReferenceException)
            //{

            //    Console.WriteLine("Coś poszło nie tak");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{

            //}

            //diary.Name = "Dzienniczek Marcina";
            //diary.Name = "Jacek Hej";

            //Console.WriteLine(diary.Name);
            #endregion
            #region Zablokowane 1.04.2020
            ////test 1.04.2020 zablokować
            //StreamWriter file = new StreamWriter("C:\\katalog\\plik.txt", false);
            //try
            //{
            //    Console.WriteLine("Podaj swoje imie:");
            //    string name = Console.ReadLine();

            //    file.WriteLine(name);
            //    file.WriteLine("Witaj piszemy do pliku tekstowego");
            //}
            //finally
            //{
            //    file.Close();
            //}


            //using (StreamWriter file2 = new StreamWriter("C:\\katalog\\plik.txt", true))
            //{
            //    file2.WriteLine("Witaj piszemy do pliku tekstowego !!!!!!");
            //}

            // test 
            #endregion
        }
        /// <summary>
        /// Tworzymy delegaty. Można je wykorzystaćkilka razy.
        /// </summary>
        /// <param name="existingName"></param>
        /// <param name="newName"></param>
        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Zmiana nazwy z {args.ExistingName} na {args.NewName}");
        }
        private static void OnNameChanged2(object sender, NameChangedEventArgs argse)
        {
            Console.WriteLine("******************");
        }
        private static void OnNameChanged3(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Hello");
        }
        private static void OnNameChanged4(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("******************");
        }


        static void WriteResult(string description, params float[] result)
        {
            Console.WriteLine(description + ": " + result[0] + " " + result[5]);
        }
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }
        static void WriteResult(string description, long result)
        {
            Console.WriteLine(description + ": " + result);
        }
        static void WriteResult(string description, float result, long test)
        {
            //altrnatyny zapis 
            //Console.WriteLine("{0}: {1:C1}: {2}: {3}: {4}: {5} ",description, result, 2, 3, 4, 5);
             Console.WriteLine($"{description}: {result:F3}: {2}: {3}: {4}: {5} ");

        }
        ////1.04.2020 zablokowane 
        //#region Metody Prywatne
        //private static void OnNameChanged(object sender, NameChangedEventArgs args)
        //{
        //    Console.WriteLine($"Zmiana nazwy z {args.ExistingName} na {args.NewName}");
        //}

        //private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        //{
        //    Console.WriteLine("***************");
        //}

        //private static void OnNameChanged3(object sender, NameChangedEventArgs args)
        //{
        //    Console.WriteLine("Hello");
        //}

        //private static void OnNameChanged4(object sender, NameChangedEventArgs args)
        //{
        //    Console.WriteLine("+++++++++++++++++++");
        //}
        //#endregion
    }
}