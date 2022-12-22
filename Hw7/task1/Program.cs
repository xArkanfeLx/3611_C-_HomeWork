Console.Clear();

int max = 100;

double[,] NewTwoDimArray(int x, int y)
{
    double[,] nums = new double[x, y];
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++) nums[i, j] = Math.Round(new Random().NextDouble() * max, 2);
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

void PrintTwoDimArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) {
            string txt = $"{arr[i,j]} ";
            if(arr[i,j]<10) txt = " " + txt;
            Console.Write(txt);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Сейчас мы создадим двумерный массив из случайных вещественных чисел!");

int[] arraySizes = NeedNewNumberArray("Введите количество строк и столбцов, от 1 до 100, через пробел");

double[,] array = NewTwoDimArray(arraySizes[0], arraySizes[1]);

Console.WriteLine("Наш массив:");
PrintTwoDimArray(array);
