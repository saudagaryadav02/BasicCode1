using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCodes
{
    internal class Reverse
    {
        public static void rev()
        {
            int l;
            Console.WriteLine("enter the lenth");
            l = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[l];

            for (int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter number " + (i + 1));
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0,j=arr.Length-1; i < j; i++,j--)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            Console.WriteLine("your revesed numbers are :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
