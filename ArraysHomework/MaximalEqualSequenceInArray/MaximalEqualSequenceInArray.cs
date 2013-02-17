using System;
using System.Linq;

class MaximalEqualSequenceInArray
{
    static void Main()
    {
        int[] numbersArray = { 1, 1, 1, 2, 2, 2, 2, 2, 2, 2 };
        int[] containerArray = new int[numbersArray.Length];
        int counter = 1;
        int maxcounter = 1;
        for (int i = 1; i < numbersArray.Length; i++)
        {
            if (numbersArray[i]==numbersArray[i-1])              //start from element with index [1] and check if it is equal to element before him
	        {
                counter++;               
                if (maxcounter < counter)                        // if we have bigger count of equal elements we start FOR cycle to fill new array
                {               
                    for (int j = counter-1; j >= 0 ; j--)
			        {
                        containerArray[j] = numbersArray[i];
                        maxcounter = counter;			 
			        } 
                }               		 
	        }
            else                                                // if elements are different  counter is set to 1
            {
                counter = 1;
            }	
        }
        foreach (int item in containerArray)                    // printing the array filled with longest equal sequence
        {
            if (item !=0)
            {
                 Console.Write(item + " ");
            }           
        }
        Console.WriteLine();
    }
}