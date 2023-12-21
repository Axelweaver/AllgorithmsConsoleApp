namespace AlgoritmesConsoleApp
{
    internal class BubbleSorting
    {
        public static int[] DescendingSort(int[] array)
        {
            Console.WriteLine("Bubble sort");

            int temp;
            for(var i = 0; i < array.Length - 1; i++)
            {
                for(var j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j + 1] > array[j])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}
