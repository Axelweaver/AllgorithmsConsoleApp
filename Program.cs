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

        Console.WriteLine("1. Сортировка пузырьком\n");

        var array = CreateArray();

        PrintArray(array);

        var startDateTime = DateTime.Now;

        Console.WriteLine("Начинаем сортировку..");

        var timeAction = PrintTime(startDateTime);
        array = BubbleSorting.DescendingSort(array, timeAction);

        Console.WriteLine("Завершили сортировку");
        PrintArray(array);
        timeAction();


    }

    private static int[] CreateArray()
    {
        return new int[] { 100, 1, 4, 121, 100, 3, 400, 45, 56, 6 };
    }

    private static void PrintArray(int[] array)
    {
        var arrayString = string.Join(',', array.Select(x => x.ToString()));

        Console.WriteLine($"Массив: [{arrayString}]");
    }

    private static Action PrintTime(DateTime startTime)
    {
        return () =>
        {
            var timeDiffMillisec = (DateTime.Now - startTime).Milliseconds;
            Console.WriteLine($"Прошло {timeDiffMillisec}мс");
        };
    }
}