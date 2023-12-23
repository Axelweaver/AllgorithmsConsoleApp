namespace AlgoritmesConsoleApp.Sorting
{
    internal class ShellSorting
    {
        public static int[] Sort(int[] array)
        {
            for (int s = array.Length / 2; s > 0; s /= 2)
            {
                for (int i = s; i < array.Length; ++i)
                {
                    for (int j = i - s; j >= 0 && array[j] > array[j + s]; j -= s)
                    {
                        int temp = array[j];
                        array[j] = array[j + s];
                        array[j + s] = temp;
                    }
                }
            }

            return array;
        }
    }
}
