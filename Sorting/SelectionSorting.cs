using AlgoritmesConsoleApp.Extensions;

namespace AlgoritmesConsoleApp.Sorting
{
    internal class SelectionSorting
    {
        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                var minIndex = i;
                for (int j = i + 1; j < array.Length; ++j)
                {
                    if(array[j] < array[minIndex]) 
                    { 
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    array.Swap(i, minIndex);
                }
            }

            return array;
        }
    }
}
