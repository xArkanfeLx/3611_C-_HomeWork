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
            if (arr[i, j] < 10) txt = " " + txt;
            Console.Write(txt);
        }
        Console.WriteLine();
    }
}

void MultiplicationTwoDimArray(int[,] arr1,int[,] arr2)
{
    int[,] array = new int[arr1.GetLength(0),arr1.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            array[i,j] = arr1[i,j]*arr2[i,j];
        }
    }
    PrintTwoDimArray(array);
}

Console.WriteLine("Сейчас мы создадим 2 двумерныx массивa из случайных целых чисел и перемножим их элементы между собой!");

int[] arraySizes = NeedNewNumberArray("Введите количество строк и столбцов для матриц, от 2 до 10, через пробел");

int[,] array1 = NewTwoDimArray(arraySizes[0], arraySizes[1]);
int[,] array2 = NewTwoDimArray(arraySizes[0], arraySizes[1]);

Console.WriteLine("Наши массивы, первый:");
PrintTwoDimArray(array1);
Console.WriteLine("");
Console.WriteLine("И второй:");
PrintTwoDimArray(array2);
Console.WriteLine("");
Console.WriteLine("Массив с перемноженными элементами:");
MultiplicationTwoDimArray(array1,array2);