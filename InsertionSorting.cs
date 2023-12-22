namespace AlgoritmesConsoleApp
{
    internal class InsertionSorting
    {
        public static int[] Sort(int[] array)
        {
            Console.WriteLine("Insertions sort");

            for (int i = 1; i < array.Length; i++)
            {
                int current = array[i];
                int j = i;
                while (j > 0 && current < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = current;
            }

            return array;
        }
    }
}
