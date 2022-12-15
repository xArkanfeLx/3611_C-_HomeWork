Console.Clear();

int _length = 0;

int NeedNewNumber(string dopTxt) {
    int num = 0;
    bool entered = false;
    while (!entered) {
        try {
            Console.Write($"{dopTxt}: ");
            num = int.Parse(Console.ReadLine());
            entered = true;
        } catch {
            Console.WriteLine("Вы ввели не число! Пожалуйста повторите ввод.");
        }
    }
    return num;
}

Console.WriteLine("Сейчас сгенерируем массив и посчитаем cумму чисел на нечётных позициях в нем!");
_length = NeedNewNumber("Введите кол-во элементов в массиве");

int[] array = new int[_length];
int sum=0;
for( int i =0;i<_length;i++) {
    array[i] = new Random().Next(-100,101);
    if(i%2==1) sum+=array[i];
}

Console.WriteLine($"Массив [{string.Join(", ",array)}] и cумма чисел на нечётных позициях в нем {sum}");