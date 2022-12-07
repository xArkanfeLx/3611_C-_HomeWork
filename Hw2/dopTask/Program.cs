Console.Clear();

int a = 1;
int max1 = 0;
int max2 = 0;

int NeedNewNumber() {
    int num = 0;
    bool entered = false;
    while (!entered) {
        try {
            Console.Write("Введите число: ");
            num = int.Parse(Console.ReadLine());
            entered = true;
        } catch {
            Console.WriteLine("Вы ввели не число! Пожалуйста повторите ввод.");
        }
    }
    return num;
}

Console.WriteLine("Сейчас мы выведем значение второго по величине элемента из вводимой последовательности! Числа должны быть больше 0, 0 заканчивает последовательность, но если перед ним уже введено 2 числа.");
int i = 0;
while (a != 0) {
    a = NeedNewNumber();
    if (i < 2 && a == 0) {
        a = 1;
        Console.WriteLine($"Перед 0 должно быть минимум 2 значения, сейчас их {i}");
    } else {
        if (a < 0) Console.WriteLine("Вы ввели не то число! Пожалуйста повторите ввод.");
        else {
            i++;
            if (a > max1) {
                max2 = max1;
                max1 = a;
            } else if (a != max1 && a > max2) {
                max2 = a;
            }
        }
    }
}
Console.WriteLine($"Второе максимальное по значению число из вводимой последовательности это чисто {max2}");