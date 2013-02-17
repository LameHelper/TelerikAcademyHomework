using System;
using System.Collections.Generic;
using System.Linq;

class MostFrequentNumInArray
{
    static void Main()
    {
        int[] inputArray = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int counter = 1;
        int maxCountsOfRepeat = 0;
        int mostFrequentNum = 0;
        Array.Sort(inputArray);
        for (int i = 0; i < inputArray.Length-1; i++)
        {
            if (inputArray[i] == inputArray[i+1])
	        {
                counter++;
	        }
            else
            {
                if (counter>maxCountsOfRepeat)
                {
                    maxCountsOfRepeat = counter;             // if we are in this part of code this means we have to save how many times its repeated;
                    mostFrequentNum = inputArray[i];         // if we are in this part of code this means we have most frequent num so we save it 
                    counter = 1;                             // We set the counter to 1 in case we have most frequent nume later in array;
                }
                else
                {
                   counter = 1;     
                }                
            }
            
        }
       Console.WriteLine("{0} ({1} times)", mostFrequentNum, maxCountsOfRepeat);
    }
}

