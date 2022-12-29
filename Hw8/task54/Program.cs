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

void SortTwoDimArray(int[,] arr)
{
    // Решение 1
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int iSort = arr.GetLength(1) - 1; iSort > 0; iSort--)
        {
            for (int j = 0; j < iSort; j++)
            {
                int num = arr[i, j];
                if (arr[i, j + 1] > num)
                {
                    arr[i, j] = arr[i, j + 1];
                    arr[i, j+1] = num;
                }
            }
        }
    }
}

Console.WriteLine("Сейчас мы создадим двумерный массив из случайных целых чисел и упорядочим по убыванию элементы каждой строки!");

int[] arraySizes = NeedNewNumberArray("Введите количество строк и столбцов, от 1 до 10, через пробел");

int[,] array = NewTwoDimArray(arraySizes[0], arraySizes[1]);

Console.WriteLine("Наш массив:");
PrintTwoDimArray(array);
SortTwoDimArray(array);
Console.WriteLine("Упорядоченный массив:");
PrintTwoDimArray(array);