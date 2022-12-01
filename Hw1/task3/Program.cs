Console.Clear();

int a;

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
void ShowEvenOrNot(int num) {
    string even = "не";
    if (num % 2 == 0) even = "";
    Console.WriteLine("Данное число " + num + " является " + even + "четным");
}

Console.WriteLine("Сейчас мы выясним, является ли число четным!");

a = NeedNewNumber();
ShowEvenOrNot(a);