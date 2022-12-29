Console.Clear();

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

Console.WriteLine("Сейчас мы выведем сумму чисел от M до N!");

int[] numbers = NeedNewNumberArray("Введите число M и N, от 1 до 50, через пробел");

int SumNums(int end)
{
    int dop = 1;
    int sum = 0;
    if (end == numbers[0]) return end;
    else
    {
        if(numbers[0]>numbers[1]) dop=-1;
        sum += end + SumNums(end - dop);
        return sum;
    }
}

Console.WriteLine($"Наша cумма от {numbers[0]} до {numbers[1]}: {SumNums(numbers[1])}");