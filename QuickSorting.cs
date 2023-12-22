namespace AlgoritmesConsoleApp
{
    public static class QuickSorting
    {
        // Not working
        public static IEnumerable<T> QuickSort<T>(this IEnumerable<T> list) where T: IComparable<T>
        {
            //Console.WriteLine("Quick sorting");

            if (!list.Any())
            {
                return Enumerable.Empty<T>();
            }

            var pivot = list.First();
            var smaller = list.Skip(1).Where(item => item.CompareTo(pivot) <= 0).QuickSort();
            var larger = list.Skip(1).Where(item => item.CompareTo(pivot) > 0).QuickSort();

            
            return smaller.Concat(new[] { pivot }).Concat(larger);
        }

        public static int[] Sort(int[] array)
        {
            return SortArray(array, 0, array.Length - 1);
        }

        private static int[] SortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];

            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j);

            if (i < rightIndex)
                SortArray(array, i, rightIndex);

            return array;
        }
    }
}
