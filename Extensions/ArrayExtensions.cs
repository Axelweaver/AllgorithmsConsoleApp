namespace AlgoritmesConsoleApp.Extensions
{
    public static class ArrayExtensions
    {
        public static void Swap(this int[] array, int i, int j) 
        {
            int glass = array[i];
            array[i] = array[j];
            array[j] = glass;
        }
    }
}
