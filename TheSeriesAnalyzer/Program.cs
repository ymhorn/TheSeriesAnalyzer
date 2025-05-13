using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSeriesAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static string InfoRecieved()
        {
            return Console.ReadLine();
        }
        static void DisplayInt(int toPrint)
        {
            Console.WriteLine(toPrint);
        }
        static void DisplayString(string toPrint)
        {
            Console.WriteLine(toPrint);
        }
        static void DisplaySeries(int[] series)
        {
            foreach (int number in series)
            {
                DisplayInt(number);
            }
        }
        static void DisplayInOrder(int[] series)
        { 
            Array.Sort(series);
            foreach (int number in series)
            {
                DisplayInt(number);
            }
        }
        static void DisplayInOppositeOfEntered(int[] series)
        {
            Array.Reverse(series);
            foreach (int number in series)
            {
                DisplayInt(number);
            }
        }
        static void MaxInSeries(int[] series)
        {
            DisplayInt(series.Max());
        }
        static void MinInSeries(int[] series)
        {
            DisplayInt(series.Min());
        }
        static void AverageInSeries(int[] series)
        {
            DisplayInt(series.Sum() / series.Length);
        }
        static void SumOfSeries(int[] series)
        {
            DisplayInt(series.Sum());
        }
        static void LengthOfSeries(int[] series)
        {
            DisplayInt(series.Length);
        }
        static int[] NumberSeries(string[] input = null)
        {

        }
        static void Menu(int[] input)
        {

        }
        static bool ValidSeries(string[] input)
        {
          
        }
        








    }
}
