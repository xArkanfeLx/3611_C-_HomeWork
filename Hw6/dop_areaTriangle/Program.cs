Console.Clear();

int max = 99999;

double[] NewPoint2D()
{
    double[] nums = new double[2];
    for (int i = 0; i < nums.Length; i++) nums[i] = Math.Round((-max + new Random().NextDouble() * max * 2), 2);
    return nums;
}

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

double GetAreaTriangle(double[] p1, double[] p2, double[] p3)
{
    double S = Math.Abs(((p1[0] - p3[0]) * (p2[1] - p3[1]) - (p2[0] - p3[0]) * (p1[1] - p3[1]))) / 2; // 0.5 * ((x1-x3)(y2-y3)-(x2-x3)(y1-y3))
    return S;
}

Console.WriteLine("Сейчас мы найдём площадь треугольника по сгенерированным точкам!");

string answer = "";
while (answer != "yes" && answer != "no")
{
    Console.Write("Вы хотите сами ввести координаты точек? Ответ yes или no! ");
    answer = Console.ReadLine();
    if (answer != "yes" && answer != "no") Console.WriteLine("Вы ответили неверно");
}

double[] point1 = new double[2];
double[] point2 = new double[2];
double[] point3 = new double[2];

if (answer == "no")
{
    point1 = NewPoint2D();
    point2 = NewPoint2D();
    point3 = NewPoint2D();
}
else
{
    string txt = "Введите координаты через пробел для точки №";
    point1 = NeedNewNumberArray($"{txt}1: ");
    point2 = NeedNewNumberArray($"{txt}2: ");
    point3 = NeedNewNumberArray($"{txt}3: ");
}

Console.WriteLine($"Площадь треугольника - {GetAreaTriangle(point1, point2, point3)}");