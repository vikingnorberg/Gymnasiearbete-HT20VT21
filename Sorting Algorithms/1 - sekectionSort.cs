using System;

namespace selectionSort
{
    class selectionSort
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

            for (int i = 0; i < list.Length - 1; i++)
            {
                int min_idx = i;

                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < list[min_idx])
                    {
                        min_idx = j;
                    }
                }

                int temp = list[min_idx];
                list[min_idx] = list[i];
                list[i] = temp;
            }

            Console.WriteLine("[{0}]", string.Join(", ", list));
        }
    }
}