using AlgoritmesConsoleApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("press enter to continue");
        Console.ReadLine();

        Console.WriteLine("Стек\n");

        var stackInstance = new Stack<string>();

        stackInstance.Push("Helen");
        stackInstance.Push("John");
        stackInstance.Push("Robert");
        stackInstance.Push("Arnold");

        var stackCount = stackInstance.Count;
        Console.WriteLine($"В стеке {stackCount} элементов");

        while(stackInstance.Count > 0)
        {
            var stackElement = stackInstance.Pop();
            Console.WriteLine($"Элемент стека: {stackElement}");
        }

        Console.WriteLine($"В стеке {stackInstance.Count} элементов");
        Console.WriteLine("\n");
        Console.WriteLine(new string('=', 100));

        Console.WriteLine("Очередь\n");

        var queueInstance = new Queue<string>();

        queueInstance.Enqueue("Helen");
        queueInstance.Enqueue("John");
        queueInstance.Enqueue("Robert");
        queueInstance.Enqueue("Arnold");
        Console.WriteLine($"Количество в очереди: {queueInstance.Count}");
        while(queueInstance.Count > 0)
        {
            var queueValue = queueInstance.Dequeue();
            Console.WriteLine($"Элемент очереди:{queueValue}");
        }
        Console.WriteLine($"Количество в очереди: {queueInstance.Count}");
        
        Console.WriteLine("\n");
        Console.WriteLine(new string('=', 100));

        Console.WriteLine("СОРТИРОВКИ\n");

        PrintSorting("1. Сортировка пузырьком. (Bubble Sort)", BubbleSorting.DescendingSort);

        PrintSorting("2. Шейкерная сортировка. (Shaker Sort)", ShakerSorting.Sort);

        PrintSorting("3. Сортировка расческой. (Combo Sort)", ComboSorting.Sort);

    }

    private static int[] CreateArray()
    {
        return new int[] { 100, 1, 4, 121, 100, 3, 400, 45, 56, 6 };
    }
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


    private static void PrintArray(int[] array)
    {
        var arrayString = string.Join(',', array.Select(x => x.ToString()));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nМассив: [{arrayString}]\n");
        Console.ForegroundColor = ConsoleColor.White;
    }

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