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
            bool valid = false;
            valid = ValidSeries(input);
            while (valid != true)
            {
                DisplayString("please enter a bunch of numbers, please put a comma(,) no spaces between each number");
                string userInput = InfoRecieved();
                input = userInput.Split(',');
                valid = ValidSeries(input);
            }
            int[] series = Array.ConvertAll(input, int.Parse);
            return series;
        }
        static void Menu(int[] input)
        {

        }
        static bool ValidSeries(string[] input)
        {
            int[] intSeries;
            if (input.Length < 3)
            {
                return false;
            }
            try
            {
                intSeries = Array.ConvertAll(input, int.Parse);
            }
            catch
            {
                return false;
            }
            foreach (int number in intSeries)
            {
                if (number < 0)
                {
                    return false;
                }
            }
            return true;
        }
        








    }
}
