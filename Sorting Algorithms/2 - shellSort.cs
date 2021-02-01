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

            int temp;

            int position = 3;

            while (position > 0)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    int j = i;
                    temp = list[i];

                    while (j >= position && list[j - position] > temp)
                    {
                        list[j] = list[j - position];
                        j -= position;
                    }
                    list[j] = temp;
                }
                if (position / 2 != 0)
                {
                    position /= 2;
                }
                else if (position == 1)
                {
                    position = 0;
                }
                else
                {
                    position = 1;
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", list));
        }
    }
}