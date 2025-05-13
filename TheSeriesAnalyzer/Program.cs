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
        static string[] functionSetter = { "abcd" };
        static void Main(string[] args)
        {
            Menu(args);
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
        static int[] NumberSeries(string[] input)
        {
            bool valid = false;
            valid = ValidSeries(input);
            while (valid != true)
            {
                DisplayString("Please enter a bunch of numbers, please put a comma(,) no spaces between each number");
                string userInput = InfoRecieved();
                input = userInput.Split(',');
                valid = ValidSeries(input);
                if (valid != true)
                {
                    DisplayString("That was not a valid bunch");
                }
            }
            int[] series = Array.ConvertAll(input, int.Parse);
            return series;
        }
        static void Menu(string[] input)
        {
            bool exit = false;
            int[] series = NumberSeries(input);
            while (exit != true)
            {
                DisplayString("\nWhat would you like to do with your numbers:\n" +
                    "a. Input a new series\n" +
                    "b. Display the series in the order it was entered\n" +
                    "c. Display the series in the reversed order that it was entered\n" +
                    "d. Display the series in order from smallest to biggest\n" +
                    "e. Display the biggest value in the series\n" +
                    "f. Display the smallest value in the series\n" +
                    "g. Display the average value in the series\n" +
                    "h. display the number of elements in the series\n" +
                    "i. display the sum of all the elements in the series\n" +
                    "j. exit the program");
                string chosenOption = InfoRecieved();
                switch (chosenOption)
                {
                    case "a":
                        series = NumberSeries(functionSetter);
                        break;
                    case "b":
                        DisplaySeries(series);
                        break;
                    case "c":
                        DisplayInOppositeOfEntered(series);
                        break;
                    case "d":
                        DisplayInOrder(series);
                        break;
                    case "e":
                        MaxInSeries(series);
                        break;
                    case "f":
                        MinInSeries(series);
                        break;
                    case "g":
                        AverageInSeries(series);
                        break;
                    case "h":
                        LengthOfSeries(series);
                        break;
                    case "i":
                        SumOfSeries(series);
                        break;
                    case "j":
                        exit = true;
                        break;
                    default:
                        DisplayString("You haave not entered a valid option!!\n" +
                            "Please check and try again");
                        break;
                }

            }

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
