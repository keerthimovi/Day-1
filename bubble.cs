using System;

namespace Bubblesorting
{
  class Bubble
    {
    static void Main(string[] args)
        {
          int[] arr = { 98, 67, 87, 18, 13, 1, 54, 95, 65 };
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
            Console.WriteLine("Sorted values are:");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.Read();
        }
    }
}
