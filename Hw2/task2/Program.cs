Console.Clear();

int a = 0;

int NeedNewNumber() {
    int num = 0;
    bool entered = false;
    while (!entered) {
        try {
            Console.Write("Введите любое число: ");
            num = int.Parse(Console.ReadLine());
            entered = true;
        } catch {
            Console.WriteLine("Вы ввели не число! Пожалуйста повторите ввод.");
        }
    }
    return num;
}
void ShowThirdNumber(int num) {
    string message = $"Третья цифра вашего числа {num} : ";
    if(Math.Abs(num)<100) message += "нет";
    else {
        int number = num; // 7834
        while (number>1000){
            number/=10;
        }
        message += $"{number%10}";
    }
    Console.WriteLine(message);
}

Console.WriteLine("Сейчас мы покажем третью цифру вашего числа!");

a = NeedNewNumber();
ShowThirdNumber(a);