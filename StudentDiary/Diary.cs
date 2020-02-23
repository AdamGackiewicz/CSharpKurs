using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {

        public Diary()
        {
            ratings = new List<float>();
            Count++ ;
            Count2++ ;
        }

        //stan (zmienne - pola)
        private List<float> ratings; // = new List<float>();

        public static float MinGrade = 0;
        public static float MaxGrade = 10;
        public static long Count = 0;
        public long Count2 = 0;   //nie jest satic wic nie ma do niego dostępu z poza Klasy Diary


        //zachowania
        /// <summary>
        /// Dodawanie oceny
        /// </summary>
        /// <param name="rating">Nowa ocena</param>
        public void AddRating(float rating)
        {
            if (rating >= 0 && rating <=10)
            {
                ratings.Add(rating);

            }
        }

        internal DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            stats.AverageGrade = sum / ratings.Count();
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        }
    }
}
