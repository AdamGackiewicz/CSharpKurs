﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);
            diary.AddRating(1.2f);
            diary.AddRating(9.6f);


            DiaryStatistics stats = diary.ComputeStatistics();
           
            Console.WriteLine("Średnia ocena: " + stats.AverageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.MinGrade);


            Diary diary2 = new Diary();
            diary2.AddRating(5);
            diary2.AddRating(2.5f);
            diary2.AddRating(3.7f);
            diary2.AddRating(4.2f);
            diary2.AddRating(7.6f);

            stats = diary2.ComputeStatistics();

            Console.WriteLine("Średnia ocena: " + stats.AverageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.MinGrade);



            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            //for (;; )
            //{
            //    Console.WriteLine("Podaj ocenę z zakresu 1-10");

            //    float rating;
            //    bool result = float.TryParse(Console.ReadLine(),out rating);


            //    if (rating == 11)
            //    {
            //        break;
            //    }
            //    if (result == true)  // zapis skrócony "if (result)"  domyślnie przyrównuje do true
            //    {
            //        if (rating > 0 && rating <=10)
            //        {
            //            diary.AddRating(rating);
            //        }
            //        else
            //        {
            //            Console.WriteLine("niepoprawna liczba. Podaj liczbe z zakresu 1-10");
            //        }

            //    }



            //}
            //Console.WriteLine("Średnia twoich ocen to : " + diary.CalculateAverage());
            //Console.WriteLine("Najwyższa ocena to : " + diary.GiveMaxRating());
            //Console.WriteLine("Najniższa ocena to : " + diary.GiveMinRating());
            //Console.ReadKey();

            //Diary diary2 = new Diary();
            //Diary diary3 = new Diary();
            //Diary diary4 = new Diary();
            //Diary diary5 = new Diary();
            Console.ReadKey();
        }
    }
}
