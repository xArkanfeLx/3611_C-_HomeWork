Console.Clear();

int a, b;

int NeedNewNumber(string nameNum) {
    int num = 0;
    bool entered = false;
    while (!entered) {
        try {
            Console.Write("Введите " + nameNum + " число: ");
            num = int.Parse(Console.ReadLine());
            entered = true;
        } catch {
            Console.WriteLine("Вы ввели не число! Пожалуйста повторите ввод.");
        }
    }
    return num;
}
void ShowMinMax(int num1, int num2) {
    int min = num1;
    int max = num2;
    if (num1 > num2) {
        min = num2;
        max = num1;
    };
    if(min == max) Console.WriteLine("Минимальное и максимальное числа равны");
    else Console.WriteLine("Минимальное число - " + min + ", максимальное число - " + max);
}

Console.WriteLine("Сейчас мы найдем наибольшее и наименьшее число из 2-ух чисел!");

a = NeedNewNumber("1-е");
b = NeedNewNumber("2-е");
ShowMinMax(a, b);