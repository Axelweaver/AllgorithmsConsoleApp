namespace AlgoritmesConsoleApp
{
    internal class ShakerSorting
    {
        public static int[] Sort(int[] array)
        {
            Console.WriteLine("Shake sorting");

            int left = 0,
                right = array.Length - 1,
                count = 0;

            while (left < right)
            {
                for(int i = left; i < right; i++)
                {
                    count++;
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
                right--;

                for(int i = right; i > left; i--)
                {
                    count++;
                    if (array[i - 1] > array[i])
                    {
                        Swap(array, i - 1, i);
                    }
                }
                left++;
            }

            return array;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int glass = array[i];
            array[i] = array[j];
            array[j] = glass;
        }
    }
}
