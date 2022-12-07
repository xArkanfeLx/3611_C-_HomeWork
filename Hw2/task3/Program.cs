Console.Clear();

int a = 0;

int NeedNewNumber() {
    int num = 0;
    bool entered = false;
    while (!entered) {
        try {
            Console.Write("Введите число от 1 до 7: ");
            num = int.Parse(Console.ReadLine());
            entered = true;
        } catch {
            Console.WriteLine("Вы ввели не число! Пожалуйста повторите ввод.");
        }
    }
    return num;
}
void ShowTheDayOff(int num) {
    string dayOff = "выходной";
    if(num<6) dayOff = "не " + dayOff;
    Console.WriteLine($"Ваша цифра {num} это {dayOff}");
}

Console.WriteLine("Сейчас мы покажем выходной день или не выходной по вашему числу!");

int b = Math.Abs(a);
while (b<1 || b>7){
    a = NeedNewNumber();
    b = Math.Abs(a);
    if (b<1 || b>7) Console.WriteLine("Вы ввели число не от 1 до 7! Пожалуйста повторите ввод.");
}
ShowTheDayOff(a);