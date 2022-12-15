Console.Clear();

int _length = 0,
_nowDay=1,
_mounth=1,
_maxNumGenerate=32,
_even=0,
_notEven=0;
string _evenDays="",
_notEvenDays="",
_answer="да";

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

int[] GenerateArray(int length){
    int[] arr = new int[length];
    for(int i=0;i<length;i++) {
        arr[i] = new Random().Next(_nowDay,_maxNumGenerate);
        _nowDay=arr[i]+1;
        if(_nowDay >=_maxNumGenerate-1) {
            _nowDay=1;
            _mounth++;
            _maxNumGenerate = 31 + _mounth%2;
        }
    }
    return arr;
}

void SerchEvenAndNotDays(int[] array){
    for(int i=0;i<array.Length;i++) {
        string day = $" {array[i]}";
        if(array[i]%2==0) {
            _evenDays+=day;
            _even++;
        }
        else {
            _notEvenDays+=day;
            _notEven++;
        }
    }
    if(_notEven>_even) _answer="нет";
    else if(_notEven==_even) _answer="возможно, зависит от учителя";
}

Console.WriteLine("Получит ли Вася 4 за четверть или нет?");
_length = NeedNewNumber("Введите кол-во дней в которые Вася получал оценки");

int[] days = GenerateArray(_length);

SerchEvenAndNotDays(days);

Console.WriteLine($"Все дни когда Вася получал оценки - [{string.Join(", ",days)}]");
Console.WriteLine($"Чётные дни когда Вася получал 4-ки -{_evenDays}");
Console.WriteLine($"Нечётные дни когда Вася получал 3-ки -{_notEvenDays}");
Console.WriteLine($"Получит ли Вася 4-ку за четверть - {_answer}");