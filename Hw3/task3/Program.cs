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
void ShowСubesOfNumbers(int num) {
    string cubesOfNum = "1";
    for(int i =2;i<=num;i++){
        cubesOfNum += $",{i*i*i}";
    }
    Console.WriteLine($"Кубы чисел от 1 до {num}: {cubesOfNum}");
}

Console.WriteLine("Сейчас мы покажем выходной день или не выходной по вашему числу!");

while (a<2){
    a = NeedNewNumber();
    if (a<2) Console.WriteLine("Вы ввели число меньше 2! Пожалуйста повторите ввод.");
}
ShowСubesOfNumbers(a);