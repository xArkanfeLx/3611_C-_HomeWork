Console.Clear();

int[,,] NewThirdDimArray(int x, int y, int z)
{
    int[,,] arr = new int[x, y, z];
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++) arr[i, j, k] = 10 + j + arr.GetLength(0) * i + (arr.GetLength(0)*arr.GetLength(1) * k);
        }
    }
    return arr;
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

void PrintThirdDimArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.WriteLine($"{arr[i,j,k]} ({i},{j},{k})");
            }
        }
    }
}

Console.WriteLine("Сейчас мы создадим 3 двумерный массив из неповторяющихся целых двузначных чисел и построчно выведем его элементы с индексом!");

int[] arraySizes = NeedNewNumberArray("Введите количество размерности для матрицы, от 2 до 4, через пробел");

int[,,] array = NewThirdDimArray(arraySizes[0], arraySizes[1], arraySizes[2]);

PrintThirdDimArray(array);