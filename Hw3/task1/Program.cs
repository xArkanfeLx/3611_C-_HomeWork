Console.Clear();

int a = 0;

int NeedNewNumber() {
    int num = 0;
    bool entered = false;
    while (!entered) {
        try {
            Console.Write("Введите любое пятизначное число: ");
            num = int.Parse(Console.ReadLine());
            entered = true;
        } catch {
            Console.WriteLine("Вы ввели не число! Пожалуйста повторите ввод.");
        }
    }
    return num;
}
void ShowSecondNumber(int num) {
    string txt = "палиндром";
    int n1 = num/10000; // 97679
    int n2 = (num/1000)%10;
    int n4 = (num/10)%10;
    int n5 = num%10;
    if(n1!=n5 || n2!=n4){
        txt = $"не {txt}";
    }
    Console.WriteLine($"Ваше число {num} - {txt}");
}

Console.WriteLine("Сейчас мы определим, является ли введенное число палиндромом или нет!");

int b = Math.Abs(a);
while (b<10000 || b>99999){
    a = NeedNewNumber();
    b = Math.Abs(a);
    if (b<10000 || b>99999) Console.WriteLine("Вы ввели не пятизначное число! Пожалуйста повторите ввод.");
}
ShowSecondNumber(a);