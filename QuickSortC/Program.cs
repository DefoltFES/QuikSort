using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.FSharp.Collections;

namespace QuickSortC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>() { -22, 2, 34, -2, 0, 9, -5, 14, -55, 74, 13};
            Console.Write("Not sorrted array \n");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            FSharpList<int> arrayFunc = ListModule.OfSeq(array);
            array = new List<int>(ListModule.ToSeq(Sort.qsort(arrayFunc)));
            Console.WriteLine();
            Console.Write("Sorted array \n");
            foreach (var item in array)
            {
                Console.Write(item+" ");
            }
            
        }

      
    }
}
