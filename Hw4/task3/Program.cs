Console.Clear();

int _length = 0;
int a = 0;

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

Console.WriteLine("Сейчас мы выведем массив из вводимой последовательности!");
_length = NeedNewNumber("Введите кол-во элементов в массиве");

// решение 1
/*
string mass="";
for( int i =1;i<=_length;i++){
    a = NeedNewNumber($"Введите {i} элемент массива");
    mass+=$"{a}";
    if(i<_length) mass+=",";
}
Console.WriteLine($"Ваш массив [{mass}]");
*/

// решение 2

int[] array = new int[_length];
for( int i =1;i<=_length;i++) array[i-1] = NeedNewNumber($"Введите {i} элемент массива");

Console.WriteLine($"Ваш массив [{string.Join(", ",array)}]");