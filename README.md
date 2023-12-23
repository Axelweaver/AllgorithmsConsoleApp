# АЛГОРИТМЫ

### Определение Алгоритма


**Алгоритм** - Это конечная совокупность точно заданных правил решения некоторого произвольного класса задач или набора инструкций, описывающих порядок действий исполнителя для решения некоторой задачи.

#### Свойства алгоритма

- **Дискретность** - совокупность простых шагов

- **Детерменированность** - в каждый момент времени следующий шаг определяет состояние системы

- **Доступность/понятность**

- **Конечность**

- **Массовость** - алгоритм может быть применён к разным наборам данных

- **Результативность**

### Виды алгоритмов

- **Механические алгоритмы** - жёсткие, детерменированные, задают действие в определённой последовательности
- **Гибкие алгоритмы** - вероятностные и эвристические
- **Вероятностный** - несколько путей и способов, приводящих к вероятному решению задачи
- **Эвристический** - использует утверждение без обоснования
- **Линейный алгоритм** - есть структура
- **Циклический алгоритм** - есть циклы
- **Вспомогательный алгоритм** - подалгоритм внутри алгоритма


### Сложность алгоритма

**При разработке алгоритма очень важно быть способным оценить ресурсы, необходимые для приведения вычислений**

#### Нотация асимптотического роста

| Обозначение | Граница| Рост |
| ----- | ----- | ---- |
| **Θ** (тэта) | Нижняя и верхняя границы, точная оценка | Равно ( = )  |
| **O** (большое) | Верхняя граница, точная оценка неизвестна | Меньше или равно ( ≤ )  |
| **o** (малое) | Верхняя граница, неточная оценка | Меньше ( < ) |
| **Ω** (омега большое) | Нижняя граница, точная оценка неизвестна | Больше или равно ( ≥ )  |
| **ω** (омега малое) | Нижняя граница, неточная оценка  | Больше ( > ) |


| Алгоритм | Эффектиность |
| ----- | ---- |
| **o (n)** |  < n |
| **O (n)** | ≤ n |
| **Θ (n)** | = n |
| **Ω (n)** | ≥ n |
| **ω (n)** | > n |

### O - нотация сложности алгоритмов

О - нотация (от немецкого "Ordung") - O (f(x)) - формула, выражающая сложность алгоритма. Для оценки сложности алгоритмов по времени или по памяти используется понятие "О большое".

#### Виды сложности алгоритмов в О-нотации

- **Константный O(1)** - нет зависимости от размера входных данных

- **Линейный O(n)** - Сложность алгоритма растёт линейно с увеличением данных. Если 1 элемент обрабатывается за 1 секунду, то 60 элементов обработается за 1 минуту. Такие алгоритмы легко узнать по наличию цикла внутри алгоритма

- **Логарифмический O(log(n))** - где n = 2 по умолчанию. Это алгоритмы, использующие принцип золотого сечения 

- **Линеарифметический O(n- log(n))** - разновидность алгоритмов, работающих по принципу "разделяй и властвуй"

- **Квадратичный O(n²)** - обычно это реализация алгоритма с двумя вложенными циклами, один внутри другого. Таким образом, количество операций будет зависеть он n * n, т.е. n². 

#### График сложности алгоритмов в О-нотации

![График сложности алгоритмов](/img/bigOcomplexityChart.png)

### Алогоритмы сортировки

#### Пузырьковая сортировка (Bubble sort)

Или **сортировка простыми обменами**. Принцип действия прост: обходимо массив от начала до конца, попутно меняя местами неотсортированные соседние элементы. В результате первого прохода на последнее место "всплывёт" максимальный элемент. Затем нужно снова обойти неотсортированную часть массива (от первого до последнего элементов). Сложность такого алгоритма всегда **O(n2)**

В коде этого репозитория это класс [BubbleSorting](/BubbleSorting.cs)

```csharp
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
```

#### Шейкерная сортировка (Shaker Sort)

Она же **сортировка перемешиванием**, она же **коктейльная сортировка**. По идее, это разновидность пузырьковой сортировки.
Начинается процесс как в «пузырьке»: выдавливаем максимум на самые задворки. После этого разворачиваемся на 180° и идём в обратную сторону, при этом уже перекатывая в начало не максимум, а минимум. Отсортировав в массиве первый и последний элементы, снова делаем кульбит. Обойдя туда-обратно несколько раз, в итоге заканчиваем процесс, оказавшись в середине списка.
Шейкерная сортировка работает немного быстрее чем пузырьковая, поскольку по массиву в нужных направлениях попеременно мигрируют и максимумы и минимумы. Улучшения, как говорится, налицо.

В коде репозитория это класс [ShakerSorting](/ShakerSorting.cs)

```csharp
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
                for(int i = left; i < right; i++)
                {
                    count++;
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
                right--;

                for(int i = right; i > left; i--)
                {
                    count++;
                    if (array[i - 1] > array[i])
                    {
                        Swap(array, i - 1, i);
                    }
                }
                left++;
            }

            return array;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int glass = array[i];
            array[i] = array[j];
            array[j] = glass;
        }
    }
```
