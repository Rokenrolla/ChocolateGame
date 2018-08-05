using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the chocolateGame function below.
     */
    static int chocolateGame(int[] arr)
    {

        int Zambilica = 0;
        int Gogu = 0;

        for (int w = 2; w < arr.Length + 1; w++)
        {
            for (int i = 0; i < arr.Length + 1 - w; i++)
            {
                int s = 0;
                for (int j = 0; j < w; j++)
                {
                    s += arr[i + j];
                }
                if (s % 2 != 0) Zambilica += 1;
                else Gogu += 1;
            }
        }
        return Zambilica;

    }

    static void Main(string[] args)
    {   
        int arrCount = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int result = chocolateGame(arr);
        Console.WriteLine(result);
    }
}
