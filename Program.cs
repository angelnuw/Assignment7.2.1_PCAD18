using System;

namespace Assignment7._2._1
{
    internal class Program
    {
        static void ShellSort(int[] array)
        {
            int n = array.Length;
            int gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j = i;

                    while (j >= gap && array[j - gap] > temp)
                    {
                        array[j] = array[j - gap];
                        j -= gap;
                    }
                    array[j] = temp;
                }
                gap /= 2;
            }
        }
        static void Main(string[] args)
        {
            //get array of integers from the user
            Console.WriteLine("Enter the number of elements in the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            ShellSort(array);
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
