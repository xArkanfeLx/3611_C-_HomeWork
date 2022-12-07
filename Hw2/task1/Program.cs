Console.Clear();

int a = 0;

int NeedNewNumber() {
    int num = 0;
    bool entered = false;
    while (!entered) {
        try {
            Console.Write("Введите любое трёхзначное число: ");
            num = int.Parse(Console.ReadLine());
            entered = true;
        } catch {
            Console.WriteLine("Вы ввели не число! Пожалуйста повторите ввод.");
        }
    }
    return num;
}
void ShowSecondNumber(int num) {
    int secondNum = num/10;
    Console.WriteLine($"Вторую цифру вашего трёхзначного числа {num}, это : {Math.Abs(secondNum%10)}");
}

Console.WriteLine("Сейчас мы покажем вторую цифру вашего трёхзначного числа!");

int b = Math.Abs(a);
while (b<100 || b>999){
    a = NeedNewNumber();
    b = Math.Abs(a);
    if (b<100 || b>999) Console.WriteLine("Вы ввели не трехзначное число! Пожалуйста повторите ввод.");
}
ShowSecondNumber(a);