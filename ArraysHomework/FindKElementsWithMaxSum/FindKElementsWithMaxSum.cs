using System;

using System.Linq;

class FindKElementsWithMaxSum
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int[] arrayOfInts = new int[N];
        int currentSum = 0;
        int maxSum = 0;
        int[] newArray = new int[K];
        int count = 0;
        for (int i = 0; i < arrayOfInts.Length; i++)
        {
            arrayOfInts[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arrayOfInts.Length-K+1; i++)
        {
            currentSum = 0;
            for (int j = 0; j < K; j++)
            {
                currentSum += arrayOfInts[i+j];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                for (int n = 0; n <= K-1; n++)
                {
                    
                    newArray[n] = arrayOfInts[i + count];
                    count++;
                }
                count = 0;
            }
        }
        //Console.WriteLine(maxSum);
        foreach (int item in newArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
