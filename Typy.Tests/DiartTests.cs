using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Typy.Tests
{
    [TestClass]
    public class DiaryTest
    {
        [TestMethod]
        public void CalculateMaxGrade()
        {
            Diary diary = new Diary();
            diary.AddRating(9f);
            diary.AddRating(8f);
            diary.AddRating(7f);
            diary.AddRating(5f);
            diary.AddRating(3f);

            DiaryStatistics stats = diary.ComputeStatistics();

            Assert.AreEqual(9, stats.MaxGrade);

            //bool value = false;
            //Assert.IsTrue(value);
        }
    }
}
