Console.Clear();

int _length = 0;
int _shift = 0;

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

int[] UpdateArray(int[] arr){
    int[] array2 = new int[_length];
    for( int i =0; i<_length; i++){
        int j = i+_shift;
        while(j>=_length) j-= _length;
        while(j<0) j+= _length;
        array2[j] = arr[i];
    }
    return array2;
}

Console.WriteLine("Сейчас мы выведем массив из вводимой последовательности и выполним сдвиг полученного массива!");
_length = NeedNewNumber("Введите кол-во элементов в массиве");

int[] array = new int[_length];
for( int i =1;i<=_length;i++) array[i-1] = NeedNewNumber($"Введите {i} элемент массива");

Console.WriteLine($"Ваш массив [{string.Join(", ",array)}]");

_shift = NeedNewNumber("Введите число, на которое нужно выполнить сдвиг в массиве");

array = UpdateArray(array);
Console.WriteLine($"Ваш смещённый массив [{string.Join(", ",array)}]");