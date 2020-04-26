using System.Collections.Generic;
using System.Linq;
using System;

namespace Members
{
    public class Diary
    {
        // konstruktor
        public Diary()
        {
            ratings = new List<float>();
        }

        // Stan (zmienne - pola)
        private List<float> ratings;

        private string _name;

        public string Name
        {
            get
            {
                return _name.ToUpper();
            }
            set
            {

                if (string.IsNullOrEmpty(value))
                {
             //       throw new ArgumentNullException("Nazwa nie moze być pusta");
                }



                if (_name != value && NameChengaed != null)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    NameChengaed(this, args);  //this niejawny argument - to odniesienie do obiektu w którym sie znajdujemy
                }
                _name = value;



                //Blokada 2 - delegaty - zostawić na później
                //if (_name != value && NameChengaed != null)
                //{
                //    NameChangedEventArgs args = new NameChangedEventArgs();
                //    args.ExistingName = _name;
                //    args.NewName = value;

                //    NameChengaed(this, args);
                //}

                //15.04.2020 tymczasowo zablokowane
                // _name = value;
            }
        }

        // Delegat - Eventy oparte są na delegatach

        //zablokowanie 15.04.2020   
        //public event NameChangedDelegate NameChengaed;
        public event NameChangedDelegate NameChengaed;

        // Zachowania
        public void AddRating(float rating)
        {
            if (rating >= 0 && rating <= 10)
            {
                ratings.Add(rating);
            }
        }

        public DiaryStatistics ComputeStatistics()
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