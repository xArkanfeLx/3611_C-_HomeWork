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

void ArithAverageTwoDimArray(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double arithAverage = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            arithAverage += arr[i, j];
        }
        arithAverage=Math.Round(arithAverage/arr.GetLength(0),1);
        string txt = $"{arithAverage} ";
        if (arithAverage < 10) txt = " " + txt;
        if (arithAverage%1==0) txt += "  ";
        Console.Write(txt);
    }
}

Console.WriteLine("Сейчас мы создадим двумерный массив из случайных целых чисел и найдём среднее арифметическое в каждом столбце!");

int[] arraySizes = NeedNewNumberArray("Введите количество строк и столбцов, от 1 до 100, через пробел");

int[,] array = NewTwoDimArray(arraySizes[0], arraySizes[1]);

Console.WriteLine("Наш массив:");
PrintTwoDimArray(array);
Console.WriteLine("Среднее арифметичекое каждого столбца:");
ArithAverageTwoDimArray(array);