using NUnit.Framework;
using ADS.Homework.Homework_24_03_2022;

namespace TestProject
{
    public class SahirTest
    {
        [Test]
        public void SahirRun()
        {
            int[,] building1 = new int[,]
            {
                {0,1,1,1,0},
                {0,1,1,1,0},
                {0,1,1,1,0},
                {0,1,1,1,0}
            };
            Assert.AreEqual(SahirTask.SahirRun(building1), 18);
            
            int[,] building2 = new int[,]
            {
                {0,0,1,0},
                {0,1,0,0}
            };
            Assert.AreEqual(SahirTask.SahirRun(building2), 5);
            
            int[,] building3= new int[,]
            {
                {0,0,1,0,0,0},
                {0,0,0,0,1,0},
                {0,0,0,0,1,0}
            };
            Assert.AreEqual(SahirTask.SahirRun(building3), 12);
        }
    }
}
