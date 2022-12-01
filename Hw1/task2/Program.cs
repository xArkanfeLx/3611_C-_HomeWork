//Console.Clear();

int a, b, c;

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
void ShowMax(int num1, int num2, int num3) {
    int max = num1;
    if (num2 > num1 && num2 > num3) max = num2; // 5,3,2 - 3,5,2 - 2,3,5 - 3,2,5
    else if (num3 > num1) max = num3;
    Console.WriteLine("Максимальное число - " + max);
}

Console.WriteLine("Сейчас мы найдем наибольшее число из 3-ех чисел!");

a = NeedNewNumber("1-е");
b = NeedNewNumber("2-е");
c = NeedNewNumber("3-е");
ShowMax(a, b, c);