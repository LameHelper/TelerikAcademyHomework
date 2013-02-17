using System;
using System.Linq;

class MaxIncreacingSequence
{
    static void Main()
    {
        int[] numbersArray = { 1, 2, 3, 4, 5, 2, 3, 4, 5, 6, 7, 8 };
        int[] containerArray = new int[numbersArray.Length];
        int counter = 1;
        int maxcounter = 1;
        int containerIndexcounter = 0;
        for (int i = 1; i < numbersArray.Length; i++)
        {
            if (numbersArray[i] == numbersArray[i - 1] + 1)          //start from element with index [1] and check if it is equal to element before him +1
            {
                counter++;
                if (maxcounter < counter)                            // if we have bigger count of equal elements we start FOR cycle to fill new array
                {
                    for (int j = counter - 1; j >= 0; j--)
                    {
                        containerArray[j] = numbersArray[i-containerIndexcounter];
                        maxcounter = counter;
                        containerIndexcounter++;
                    }
                    containerIndexcounter = 0;
                }
            }
            else                                                
            {
                counter = 1;                                        // if elements are different  counter is set to 1
            }
        }
        foreach (int item in containerArray)                        // printing the array filled with longest increacing sequence
        {
            if (item != 0)
            {
                Console.Write(item + " ");
            }
        }
        Console.WriteLine();
    }
}

