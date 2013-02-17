using System;
using System.Linq;

class ComparingTwoArrays
{
    static void Main()
    {
        int[] firstArray = new int[10];
        int[] secondArray = new int[10];
        int[] bigNumbersArray = new int[10];
        for (int i = 0; i < 10; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());            // First line is first element of first array
            secondArray[i] = int.Parse(Console.ReadLine());           // Second line is first element of second array
           
            if (firstArray[i]>secondArray[i])                           //compare both inputs and put bigger number in bigNumberArray
            {
                bigNumbersArray[i] = firstArray[i];
            }
            else
            {
                bigNumbersArray[i] = secondArray[i];
            }
        }

    }
}

