using System;

namespace Bubble_sort
{
    using System;
    namespace BubbleSort
    {
        class Sortvalue
        {
            static void Main(string[] args)
            {
                int[] arr = { 98, 87, 64, 92, 13 };
                int temp;
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    for (int i = 0; i <= arr.Length - 2; i++)
                    {
                        if (arr[i] > arr[i + 1])
                        {
                            temp = arr[i + 1];
                            arr[i + 1] = arr[i];
                            arr[i] = temp;
                        }
                    }
                }
                Console.WriteLine("Sorted value:");
                foreach (int p in arr)
                    Console.Write(p + " ");
                Console.Read();
            }
        }
    }
}
