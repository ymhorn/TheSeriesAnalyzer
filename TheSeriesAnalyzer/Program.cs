using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This program will produce all sorts of calculations on a series of numbers
namespace TheSeriesAnalyzer
{
    internal class Program
    {
        static string[] functionSetter = { "abcd" };
        //This function will cause the program to run
        static void Main(string[] args)
        {
            Menu(args);
        }
        //Recieves information from user
        static string InfoRecieved()
        {
            return Console.ReadLine();
        }
        //Displays numbers
        static void DisplayInt(int toPrint)
        {
            Console.WriteLine(toPrint);
        }
        //Displays words
        static void DisplayString(string toPrint)
        {
            Console.WriteLine(toPrint);
        }
        //To display the users series
        static void DisplaySeries(int[] series)
        {
            foreach (int number in series)
            {
                DisplayInt(number);
            }
        }
        //To display the series in numerical order
        static void DisplayInOrder(int[] series)
        { 
            for (int i = 0; i < series.Length-1; i++)
            {
                for (int j = 0; j < series.Length-i-1; j++)
                {
                    if (series[j] > series[j+1])
                    {
                        (series[j], series[j + 1]) = (series[j + 1], series[j]);
                    }
                }
            }
            foreach (int number in series)
            {
                DisplayInt(number);
            }
        }
        //To display the series LIFO
        static void DisplayInOppositeOfEntered(int[] series)
        {
            for (int i = series.Length - 1; i >= 0; i--)
            {
                DisplayInt(series[i]);
            }
        }
        //Biggest number in series
        static void MaxInSeries(int[] series)
        {
            int biggest = series[0];
            foreach (int number in series)
            {
                if (number > biggest)
                {
                    biggest = number;
                }
            }
            DisplayInt(biggest);
        }
        //Smallest number in series
        static void MinInSeries(int[] series)
        {
            int smallest = series[0];
            foreach (int number in series)
            {
                if (number < smallest)
                {
                    smallest = number;
                }
            }
            DisplayInt(smallest);
        }
        //The average of the series
        static void AverageInSeries(int[] series)
        {
            int sum = 0;
            foreach (int number in series)
            {
                sum += number;
            }
            DisplayInt(sum / series.Length);
        }
        //Displays the sum of all the numbers 
        static void SumOfSeries(int[] series)
        {
            int sum = 0;
            foreach (int number in series)
            {
                sum += number;
            }
            DisplayInt(sum);
        }
        //The amount of numbers in the series
        static void LengthOfSeries(int[] series)
        {
            DisplayInt(series.Length);
        }
        //Function that recieves/creates the series
        static int[] NumberSeries(string[] input)
        {
            bool valid = false;
            valid = ValidSeries(input);
            while (valid != true)
            {
                DisplayString("Please enter a bunch of at least 3 numbers, please put a comma(,) no spaces between each number");
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
        //Arranges all the functions and displays all options to user on console
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
                        DisplayString("You have not entered a valid option!!\n" +
                            "Please check and try again");
                        break;
                }

            }

        }
        //Checks the validity of the series
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
