using System;

namespace quickSort
{
    class Program
    {
        static void swap(int x, int y, int[] array)
        {
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }

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

        private static void quickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);

                if (pivot > 1)
                {
                    quickSort(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(array, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];
            while (true)
            {
                while (array[left] < pivot)
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (array[left] == array[right]) return right;

                    swap(left, right, array);
                }
                else
                {
                    return right;
                }
            }
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

            quickSort(list, 0, list.Length - 1);

            Console.WriteLine("[{0}]", string.Join(", ", list));
        }
    }
}