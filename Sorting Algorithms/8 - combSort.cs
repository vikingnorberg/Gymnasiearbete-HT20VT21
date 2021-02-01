using System;
using System.Diagnostics;

namespace combSort
{
    class combSort
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

        static int getNextGap(int gap)
        {
            // Shrink gap by Shrink factor 
            gap = (gap * 10) / 13;
            if (gap < 1)
                return 1;
            return gap;
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


            // initialize gap 
            int gap = items;

            // Initialize swapped as true to  
            // make sure that loop runs 
            bool swapped = true;

            // Keep running while gap is more than  
            // 1 and last iteration caused a swap 
            while (gap != 1 || swapped == true)
            {
                // Find next gap 
                gap = getNextGap(gap);

                // Initialize swapped as false so that we can 
                // check if swap happened or not 
                swapped = false;

                // Compare all elements with current gap 
                for (int i = 0; i < items - gap; i++)
                {
                    if (list[i] > list[i + gap])
                    {
                        // Swap arr[i] and arr[i+gap] 
                        swap(i, i + gap, list);

                        // Set swapped 
                        swapped = true;
                    }
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", list));
        }
    }
}