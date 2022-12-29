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

Console.WriteLine("Сейчас мы вычислим функцию Аккермана с помощью рекурсии из чисел от N до M!");

int[] numbers = NeedNewNumberArray("Введите число N и M, от 1 до 4, через пробел");

int AckFun(int n, int m){
   if (n == 0)  return m + 1;
   else if( m == 0 ) return AckFun (n - 1, 1);
   else return AckFun(n - 1, AckFun (n, m - 1));
}

Console.WriteLine(AckFun(numbers[0],numbers[1]));