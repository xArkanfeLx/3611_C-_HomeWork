Console.Clear();

int _length = 0;
double _maxNumGenerate=5000.0;
double _max=0,
_min=_maxNumGenerate;

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

double[] GenerateArray(int length){
    double[] arr = new double[length];
    for(int i=0;i<length;i++) arr[i] = Math.Round(new Random().NextDouble() * _maxNumGenerate,2);
    return arr;
}

void SearchMinMaxInArray(double[] array){
    for( int i =0;i<array.Length;i++) {
        if(_max < array[i]) _max = array[i];
        if(_min > array[i]) _min = array[i];
    }
}

Console.WriteLine("Сейчас сгенерируем массив и найдём разницу между максимальным и минимальным элементами!");
_length = NeedNewNumber("Введите кол-во элементов в массиве");

double[] array = GenerateArray(_length);

SearchMinMaxInArray(array);

Console.WriteLine($"Массив [{string.Join(", ",array)}], максимальный элемент {_max}, минимальный элемент {_min}, разница между ними {_max-_min}");