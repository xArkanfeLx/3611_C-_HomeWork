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

Console.WriteLine("Сейчас мы выведем все натуральные числа в промежутке от N до M!");

int[] numbers = NeedNewNumberArray("Введите число M и N, от 1 до 50, через пробел");

string WriteNums(int end)
{
    int dop = 1;
    string txt = "";
    if (end == numbers[1]) return end.ToString();
    else
    {
        if(numbers[1]>numbers[0]) dop=-1;
        txt = $"{WriteNums(end - dop)} {end}";
        return txt;
    }
}

Console.WriteLine($"Наша последовательность от {numbers[1]} до {numbers[0]}: {WriteNums(numbers[0])}");