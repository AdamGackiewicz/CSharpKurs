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
        }

        //stan (zmienne - pola)
        List<float> ratings; // = new List<float>();

        //zachowania
        /// <summary>
        /// Dodawanie oceny
        /// </summary>
        /// <param name="rating">Nowa ocena</param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }
        /// <summary>
        /// Obliczamy średnią naszych ocen
        /// </summary>
        /// <returns></returns>
        public float CalculateAverage()
        {
            float sum = 0, avg = 0; 
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            avg = sum / ratings.Count();

            return avg;
        }   
        /// <summary>
        /// Pobiera najwyższą ocene
        /// </summary>
        /// <returns></returns>
        public float GiveMaxRating()
        {

            return ratings.Max();
        }
        /// <summary>
        /// Pobieramy najniższą ocene
        /// </summary>
        /// <returns></returns>
        public float GiveMinRating()
        {
            return ratings.Min();
        }       
    }
}
