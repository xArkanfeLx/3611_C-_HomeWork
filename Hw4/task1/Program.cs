Console.Clear();

int a = 0,
b=0;

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
void ShowNumPow(int num, int pow) {
    int res = num;
    for( int i = 1;i<pow;i++) res*=num;
    Console.WriteLine($"Ваше число {num} в степени {pow} равно {res}");
}

Console.WriteLine("Сейчас мы возведем число в степень второго числа!");

a = NeedNewNumber("");
while(b<=0){
    b = NeedNewNumber("натуральное ");
    if(b<=0) Console.WriteLine("Вы ввели не натуральное число!");
}
ShowNumPow(a,b);