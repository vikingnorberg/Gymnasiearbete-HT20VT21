using System;

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

            for (int i = 0; i < items; i++)
            {
                for (int j = 0; j < items - i - 1; j++)
                {
                    if (list[j] > list[i])
                    {
                        swap(i, j, list);
                    }
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", list));
        }
    }
}