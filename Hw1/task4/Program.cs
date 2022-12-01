Console.Clear();

int a = 0;

int NeedNewNumber() {
    int num = 0;
    bool entered = false;
    while (!entered) {
        try {
            Console.Write("Введите число больше 1: ");
            num = int.Parse(Console.ReadLine());
            entered = true;
        } catch {
            Console.WriteLine("Вы ввели не число! Пожалуйста повторите ввод.");
        }
    }
    return num;
}
void ShowEvenNumbers(int num) {
    int n = 2;
    string evenNum = " 2";
    while (n < num-2) {
        n += 2;
        evenNum += ", " + n;
    }
    Console.WriteLine($"Наши четные числа от 1 до {num} это :{evenNum}");
}

Console.WriteLine("Сейчас мы выясним, какие четные числа есть от 1 до нашего числа!");

while (a<=1){
    a = NeedNewNumber();
    if(a<=1) Console.WriteLine("Вы ввели число меньше 2! Пожалуйста повторите ввод.");
}
ShowEvenNumbers(a);