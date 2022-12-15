Console.Clear();

int a = 0;

int NeedNewNumber(string dopText) {
    int num = 0;
    bool entered = false;
    while (!entered) {
        try {
            Console.Write($"Введите {dopText}число: ");
            num = int.Parse(Console.ReadLine());
            entered = true;
        } catch {
            Console.WriteLine("Вы ввели не число! Пожалуйста повторите ввод.");
        }
    }
    return num;
}
void ShowSumNumbers(int num) {
    int res = 0,
    number = Math.Abs(num);
    while (number>0) {
        res += number%10;
        number/=10;
    }
    Console.WriteLine($"Сумма цифр числа {num} равна {res}");
}

Console.WriteLine("Сейчас мы вычислим сумму всех цифр введённого числа!");

a = NeedNewNumber("");

ShowSumNumbers(a);