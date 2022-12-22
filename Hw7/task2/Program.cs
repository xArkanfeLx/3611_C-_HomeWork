Console.Clear();

int[,] NewTwoDimArray(int x, int y)
{
    int[,] nums = new int[x, y];
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++) nums[i, j] = new Random().Next(0, 10);
    }
    return nums;
}

int[] NeedNewNumberArray(string dopTxt)
{
    int[] nums = new int[1];
    bool entered = false;
    while (!entered)
    {
        try
        {
            Console.Write($"{dopTxt}: ");
            nums = Console.ReadLine().Split(" ").Select(num => int.Parse(num)).ToArray();
            entered = true;
        }
        catch
        {
            Console.WriteLine("Вы где-то ошиблись! Пожалуйста повторите ввод.");
        }
    }
    return nums;
}

void PrintTwoDimArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            string txt = $"{arr[i, j]} ";
            Console.Write(txt);
        }
        Console.WriteLine();
    }
}

void ShowElementTwoDimArray(int[] pos,int[,] arr)
{
    if (pos[0]-1 < arr.GetLength(0) && pos[1]-1 < arr.GetLength(1))
        Console.WriteLine($"Ваш элемент: {arr[pos[0]-1,pos[1]-1]}");
    else
        Console.WriteLine($"Элемента с позицией {string.Join(" ",pos)} нет!");
}

Console.WriteLine("Сейчас мы создадим двумерный массив из случайных целых чисел и найдём среднее арифметическое в каждом столбце!");

int[] arraySizes = NeedNewNumberArray("Введите количество строк и столбцов, от 1 до 10, через пробел");

int[,] array = NewTwoDimArray(arraySizes[0], arraySizes[1]);

Console.WriteLine("Наш массив:");
PrintTwoDimArray(array);

int[] positionInArray = NeedNewNumberArray("Введите позицию предполагаемого элемента от 1 до 10, через пробел");

ShowElementTwoDimArray(positionInArray,array);