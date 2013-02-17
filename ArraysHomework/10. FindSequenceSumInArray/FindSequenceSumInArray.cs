using System;

using System.Linq;

class FindSequenceSumInArray
{
    static void Main()
    {
        int[] inputArray = new int[] { 4, 4, 1, 4, 2, 5, 8 };
        int inputSum = 7;
        int currentSum = 0;
        int counter = 0;
        int failCounter = 0 ;
        for (int i = 0; i < inputArray.Length; i++)
        {
            for (int j = 0; j < inputArray.Length-i; j++)
            {                 
                currentSum += inputArray[i + j];
                    
                if (currentSum == inputSum)
                {
                    //TODO + Break
                }                
            }
            failCounter++;
            currentSum = 0;

        }
    }
}

