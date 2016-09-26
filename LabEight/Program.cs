using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEight //this is the method class you would call when you want to use it elsewhere
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Batting Average Calculator!");
            Console.WriteLine();
            //string contYes ="";
            //do
            //{
            Console.WriteLine("Enter number of times at bat:\n");
            int numTimesAtBat = int.Parse(Console.ReadLine());


            int[] battingSheet = new int[numTimesAtBat];

            Console.WriteLine("0=out, 1=single, 2=double, 3=triple, 4=homerun");
            Console.WriteLine();
            //beginning of result loop here
            for (int i = 0; i < battingSheet.Length; i++)
            {

                Console.Write($"Result for at-bat:{i} ");
                string answer = Console.ReadLine(); int resultBatNum = int.Parse(answer);
                //we need to hold the value of answer in the array (initializing)
                battingSheet[i] = resultBatNum;
                
            //need to put a check number for answer
        }//end of result loop
            Console.WriteLine("\nBatting Average:" + CalculateBattingAverage(battingSheet));
            Console.WriteLine("\nSlugging Average: " + SluggingPercentage(battingSheet));
            //do the loop here.
        // double battingAvg = new CalculateBattingAverage(int[] battingSheet);
        // double slugPercent = new SluggingPercentage(int[] battingSheet) 
    }

    //the method is going to go inside the class

    public static double CalculateBattingAverage(int[] battingSheet)


    {
        Console.WriteLine("Enter number of times at bat:\n");
        int numTimesAtBat = int.Parse(Console.ReadLine());
        //CONNECT THE CALCULATION TO THE OUTPUT

        //method to calculate the batting average
        double totalNumAtBats = battingSheet.Length;
        double numerator = 0;
        for (int i = 0; i < battingSheet.Length; i++)
        {
            int totalScored = battingSheet[i];
            if (totalScored >= 1)
            {
                numerator = numerator + 1;
            }
        }
        return numerator / totalNumAtBats;

    }
    public static double SluggingPercentage(int[] battingSheet)
    {
        double totalNumAtBats = battingSheet.Length;
        double numerator = 0;
        for (int i = 0; i < battingSheet.Length; i++)
        {
            int totalScored = battingSheet[1];
            numerator = numerator + battingSheet[i];

        }
        return numerator / totalNumAtBats;

    } //Console.WriteLine ("Do you want to continue?y/n \n");
      //Console.WriteLine();
      //}while (
}
}









