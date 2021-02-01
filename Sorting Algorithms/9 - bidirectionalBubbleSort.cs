using System;
using System.Diagnostics;

// My Name is dick

namespace bidirectionalBubbleSort
{
    class bidirectionalBubbleSort 
    {
        static void shuffle<T>(T[] array)
        {
            Random rnd = new Random();

	        int n = array.Length;
	        for (int i = 0; i < n; i++)
	        {
	            int r = i + (int)(rnd.NextDouble() * (n - i));
	            T t = array[r];
	            array[r] = array[i];
	            array[i] = t;
	        }
        }
        
        static void swap(int x, int y, int[] array)
        {
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }
        
        static void Main(string[] args)
        {
            int items = 20;

            int[] list = new int[items];

            for (int i = 0; i < items; i++) 
            {
                list[i] = i;
            }

            Console.WriteLine("[{0}]", string.Join(", ", list));

            shuffle(list);

            Console.WriteLine("[{0}]", string.Join(", ", list));

            int start = 0;
            int end = list.Length;
            bool swapped = true; 

            while (swapped)
            {
                for (int i = start; i < end - 1; i++) 
                {
                    if (list[i] > list[i + 1]) 
                    {
                        swap(i, i + 1, list);
                        swapped = true;
                    }
                }
                if (swapped == false) 
                {
                    break;
                }
                swapped = false;
                end -= 1;
                for (int i = end - 1; i >= start; i--)
                {
                    if (list[i] > list[i + 1]) 
                    {
                        swap(i, i + 1, list);
                        swapped = true;
                    }
                }
                start += 1;
            }

            Console.WriteLine("[{0}]", string.Join(", ", list));
        }
    }
}