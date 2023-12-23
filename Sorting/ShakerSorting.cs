using AlgoritmesConsoleApp.Extensions;

namespace AlgoritmesConsoleApp.Sorting
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
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (array[i] > array[i + 1])
                    {
                        array.Swap(i, i + 1);
                    }
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (array[i - 1] > array[i])
                    {
                        array.Swap(i - 1, i);
                    }
                }
                left++;
            }

            return array;
        }
    }
}
