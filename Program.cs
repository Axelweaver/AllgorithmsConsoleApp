using AlgoritmesConsoleApp;

/// <summary>
/// Основной класс программы
/// </summary>
internal class Program
{
    /// <summary>
    /// Главный метод как точка входа в программу
    /// </summary>
    /// <param name="args">Принимаемые аргументы перед запуском</param>
    private static void Main(string[] args)
    {
        Console.WriteLine("press enter to continue");
        Console.ReadLine();
        
        Console.WriteLine("\n");
        Console.WriteLine(new string('=', 100));

        Console.WriteLine("СОРТИРОВКИ\n");

        PrintSorting("1. Сортировка пузырьком. (Bubble Sort)", BubbleSorting.DescendingSort);

        PrintSorting("2. Шейкерная сортировка. (Shaker Sort)", ShakerSorting.Sort);

        PrintSorting("3. Сортировка расческой. (Combo Sort)", ComboSorting.Sort);

        PrintSorting("4. Сортировка вставками. (Insertion Sort)", InsertionSorting.Sort);

        PrintSorting("5. Быстрая сортировка. (Quick Sort)", QuickSorting.Sort);

    }

    /// <summary>
    /// Метод, создающий целочисленный массив
    /// </summary>
    /// <returns></returns>
    private static int[] CreateArray()
    {
        return new int[] { 100, 1, 4, 121, 100, 3, 400, 45, 56, 6, 77, 99, 155, 388, 5, 255, 177, 7, 201,
            13, 55, 86, 2, 19, 144, 15, 63, 277};
    }

    /// <summary>
    /// Вспомогательный метод для вывода на экран алгоритма сортировки
    /// </summary>
    /// <param name="name">Название сортировки</param>
    /// <param name="sortingAction">Делегат для самой сортировки</param>
    private static void PrintSorting(string name, Func<int[], int[]> sortingAction)
    {
        Console.WriteLine("\n");
        Console.WriteLine(new string('=', 100));
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{name}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(new string('=', 100));
        var array = CreateArray();

        PrintArray(array);
        Console.WriteLine("Начинаем сортировку..");
        var timeAction = PrintTime(DateTime.Now);
        sortingAction(array);

        Console.Write("Завершили сортировку.");
        timeAction();
        PrintArray(array);

    }

    /// <summary>
    /// Вспомогательный метод для вывода на экран содержимого массива
    /// </summary>
    /// <param name="array">Массив</param>
    private static void PrintArray(int[] array)
    {
        var arrayString = string.Join(',', array.Select(x => x.ToString()));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nМассив: [{arrayString}]\n");
        Console.ForegroundColor = ConsoleColor.White;
    }

    /// <summary>
    /// Вспомогательный метод для вывода разницы времени в миллисекундах с микросекундами
    /// </summary>
    /// <param name="startTime">Начальное время</param>
    /// <returns></returns>
    private static Action PrintTime(DateTime startTime)
    {
        return () =>
        {
            var timeDiffMillisec = (DateTime.Now - startTime).Milliseconds;
            var timeDiffMicrosec = (DateTime.Now - startTime).Microseconds;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($" (Прошло {timeDiffMillisec},{timeDiffMicrosec}мс )\n");
            Console.ForegroundColor = ConsoleColor.White;
        };
    }
}