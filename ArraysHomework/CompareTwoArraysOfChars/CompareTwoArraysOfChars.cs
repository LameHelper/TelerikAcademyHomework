using System;
using System.Linq;

class ComparingTwoArraysOfChars
{
    static void Main()
    {
        char[] firstArray = new char[10];
        char[] secondArray = new char[10];
        char[] bigCharsArray = new char[10];
        for (int i = 0; i < 10; i++)
        {
            firstArray[i] = char.Parse(Console.ReadLine());            // First line is first element of first array
            secondArray[i] = char.Parse(Console.ReadLine());           // Second line is first element of second array

            if (firstArray[i] > secondArray[i])                           //compare both inputs and put bigger char in bigCharsArray
            {
                bigCharsArray[i] = firstArray[i];
            }
            else
            {
                bigCharsArray[i] = secondArray[i];
            }
        }

    }
}