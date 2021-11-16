using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtilities
{

    /// <summary>
    /// <para>A a small DLL with usefull functions to use in CONSOLE projects - C#</para>
    /// <para>Use the Utilities class without any instatiation for ease-of-use</para>
    /// </summary>
    public class Utilities
    {
        /// <summary>
        /// Continuously ask the user for input until the input is not empty of null
        /// </summary>
        /// <param name="prompt">What the user will see in the console</param>
        /// <returns>A string of the user input</returns>
        public static string ReadString(string prompt)
        {
            string tempStr = "";
            do
            {
                Console.WriteLine(prompt);
                tempStr = Console.ReadLine();
            } while (string.IsNullOrEmpty(tempStr) || string.IsNullOrWhiteSpace(tempStr));

            return tempStr;
        }

        /// <summary>
        /// Print a message to the user asking him to give you a number
        /// then parse the number and return it through this method
        /// </summary>
        /// <param name="userPrompt">MUST BE A STRING</param>
        /// <returns>The parsed input of the user to type of int</returns>
        public static int ReadInt(string userPrompt)
        {
            int tempInt = 0;
            string tempStr = "";

            while (true)
            {
                tempStr = ReadString(userPrompt);
                
                if (int.TryParse(tempStr, out tempInt))
                    break; // break the while loop if Parsing was succesfull
                else
                    Console.WriteLine("Invalid input\n");
            }

            return tempInt;
        }

        /// <summary>
        /// Print the array items of the supplied array
        /// </summary>
        /// <param name="arrayToPrint">The array you want to print the items of.</param>
        public static void PrintArrayInt(int[] arrayToPrint)
        {
            foreach (int index in arrayToPrint)
            {
                Console.Write("["+index+"] ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Print the array items of the supplied 2D array from both dimensions.
        /// </summary>
        /// <param name="arrayToPrint">The 2D array to print</param>
        public static void PrintArrayInt(int[,] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToPrint.GetLength(1); j++)
                {
                    Console.Write("[" + arrayToPrint[i, j] + "]");

                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Print the array items of the supplied array with or without zeros
        /// </summary>
        /// <param name="arrayToPrint">The array you want to print the items of.</param>
        /// <param name="printZeros">If true then zeros will be printed else zeros will be ommited </param>
        public static void PrintArrayInt(int[] arrayToPrint, bool printZeros)
        {
            if (!printZeros)
            {
                foreach (int index in arrayToPrint)
                {
                    if (index == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(index + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                PrintArrayInt(arrayToPrint);
            }
        }

        /// <summary>
        /// Print the array items of the supplied 2D array with or without zeros
        /// </summary>
        /// <param name="arrayToPrint">The 2D Array to get printed in the Console</param>
        /// <param name="printZeros">If true then zeros will be printed else zeros will be ommited</param>
        public static void PrintArrayInt(int[,] arrayToPrint,bool printZeros)
        {
            if (!printZeros)
            {
                foreach (int index in arrayToPrint)
                {
                    if (index == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(index + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                PrintArrayInt(arrayToPrint);
            }
        }

        /// <summary>
        /// Use this method if you want to populate an array with random numbers set between min and max.
        /// </summary>
        /// <param name="arrayToPop">The array you want to populate with numbers</param>
        /// <param name="minNum">The minimum number to generate</param>
        /// <param name="maxNum">The maximum number to generate</param>
        public static void PopulateArrayRndm(int[] arrayToPop, int minNum, int maxNum)
        {
            Random randomizer = new Random();

            for (int i = 0; i < arrayToPop.Length; i++)
            {
                arrayToPop[i] = randomizer.Next(minNum, maxNum);
            }
        }

        /// <summary>
        /// Use this method if you want to populate a 2D array with random numbers set between min and max.
        /// </summary>
        /// <param name="arrayToPop">The array to populate with ints</param>
        /// <param name="dim0Length">The length of the first dimension of the array</param>
        /// <param name="dim1Lenght">The length of the second dimension of the array</param>
        /// <param name="minNum">The minimum number to generate</param>
        /// <param name="maxNum">The maximum number to generate</param>
        public static void PopulateArrayRndm(int[,] arrayToPop,int dim0Length, int dim1Lenght, int minNum, int maxNum)
        {
            Random randomizer = new Random();

            for (int i = 0; i < dim0Length; i++)
            {
                for (int j = 0; j < dim1Lenght; j++)
                {
                    arrayToPop[i, j] = randomizer.Next(minNum, maxNum);
                }
            }
        }
    }
}
