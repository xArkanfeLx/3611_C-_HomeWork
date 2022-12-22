Console.Clear();

double[] NeedNewNumberArray(string dopTxt)
{
    double[] nums = new double[1];
    bool entered = false;
    while (!entered)
    {
        try
        {
            Console.Write($"{dopTxt}: ");
            nums = Console.ReadLine().Split(" ").Select(num => double.Parse(num)).ToArray();
            entered = true;
        }
        catch
        {
            Console.WriteLine("Вы где-то ошиблись! Пожалуйста повторите ввод.");
        }
    }
    return nums;
}

double[] GetPoint2Lines(double[] arr1, double[] arr2)
{
    double[] point = new double[2];
    point[0] = (arr2[1] - arr1[1]) / (arr1[0] - arr2[0]); // k1*x+b1-k2*x-b2 = 0 _ k1*x-k2*x = b2-b1 _ x = (b2-b1) / (k1-k2)
    Console.WriteLine(point[0]);
    point[1] = arr1[0] * point[0] + arr1[1];
    return point;
}

Console.WriteLine("Сейчас мы найдём точку пересечения двух прямых, заданных уравнением y = k * x + b");


double[] line1 = NeedNewNumberArray("Введите k и b, через пробел, для 1-ой линии");

double[] line2 = NeedNewNumberArray("Введите k и b, через пробел, для 2-ой линии");

if (line1[0] == line2[0] && line1[1] == line2[1])
{
    Console.WriteLine($"Линии идентичны");
}
else if (line1[0] == line2[0] && line1[1] != line2[1])
{
    Console.WriteLine($"Линии параллельны");
}
else Console.WriteLine($"Координаты точки пересечения линий - [{string.Join(" , ", GetPoint2Lines(line1, line2))}]");