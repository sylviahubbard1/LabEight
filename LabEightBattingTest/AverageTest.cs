using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabEight;

namespace LabEightBattingTest
{

    [TestClass]
    public class AverageTest
    {
        [TestMethod]
        public void TestBattingPercentageIs0whenNoRuns()
        {
            int[] battingSheet = new int[5];
            //creating a new int array and naming it batting sheet which will equal new constructor and how many
            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 0;
            battingSheet[3] = 0;
            battingSheet[4] = 0;
            //put examples in the five places
            //array of integers  that equals our batting sheet.
            //input will be array output will be double average

            //now we want to call a method - using Calculate for batting average
            double average = Program.CalculateBattingAverage(battingSheet);
            //want to call the method by going program dot calculatebattingaverage and pass it in the parenthesis
            //thru batting sheet and make it return something "equal soemthing "(double average)

            //now you must assert something
            Assert.AreEqual(0, average); //areEqual is a method that takes two numbers (two objects) 
            //first number is what is expected and the number that comes out in the test
        }
        [TestMethod]
        public void TestBattingPercentageIs60()
        {
            int[] battingSheet = new int[5];

            battingSheet[0] = 0;
            battingSheet[1] = 0;
            battingSheet[2] = 2;
            battingSheet[3] = 4;
            battingSheet[4] = 1;

            double average = Program.CalculateBattingAverage(battingSheet);

            Assert.AreEqual(0.6, average);
        }
    }
}
