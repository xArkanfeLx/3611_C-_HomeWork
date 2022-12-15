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

Console.WriteLine("Сейчас сгенерируем массив из положительных трёхзначных чисел и покажем, сколько в нём четных чисел!");
_length = NeedNewNumber("Введите кол-во элементов в массиве");

int[] array = new int[_length];
int evenNum=0;
for( int i =0;i<_length;i++) {
    array[i] = new Random().Next(100,1000);
    if(array[i]%2 ==0) evenNum++;
}

Console.WriteLine($"Ваш массив [{string.Join(", ",array)}] и чётных чисел в нем {evenNum}");