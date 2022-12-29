Console.Clear();

int[,] NewTwoDimArray(int x, int y)
{
    int[,] nums = new int[x, y];
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++) nums[i, j] = new Random().Next(0, 100);
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
            string txt = $"{arr[i, j]}   ";
            if (arr[i, j] < 10) txt = " " + txt;
            Console.Write(txt);
        }
        Console.WriteLine();
    }
}

void MinInTwoDimArray(int[,] arr, int length)
{
    int[] array = new int[length];
    int min=0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        array[i]=0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[i] += arr[i,j];
        }
    }
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i]<array[min]) min = i;
    }
    Console.WriteLine("");
    Console.Write($"Строка с минимальной суммой в {array[min]} под номером {min+1}: ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[min,j]} ");
    }
}

Console.WriteLine("Сейчас мы создадим прямоугольный двумерный массив из случайных целых чисел и найдём строку с наиеньшей суммой!");

int[] arraySizes = {1, 2};
while (arraySizes[1] >= arraySizes[0])
{
    arraySizes = NeedNewNumberArray("Введите количество строк и столбцов, от 1 до 10, через пробел");
    if (arraySizes[1] >= arraySizes[0]) Console.WriteLine("Строк меньше чем стобцов или они равны, пожалуйста, повторите ввод!");
}

int[,] array = NewTwoDimArray(arraySizes[0], arraySizes[1]);

Console.WriteLine("Наш массив:");
PrintTwoDimArray(array);
MinInTwoDimArray(array, arraySizes[0]);