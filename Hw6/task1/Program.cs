Console.Clear();

int[] NeedNewNumberArray(string dopTxt) {
    int[] nums = new int[1];
    bool entered = false;
    while (!entered) {
        try {
            Console.Write($"{dopTxt}: ");
            nums = Console.ReadLine().Split(" ").Select(num => int.Parse(num)).ToArray();
            entered = true;
        } catch {
            Console.WriteLine("Вы где-то ошиблись! Пожалуйста повторите ввод.");
        }
    }
    return nums;
}

int NumInArrayAfterZero(int[] arr){
    int nums = 0;
    foreach (int elem in arr) if(elem>0) nums++;
    return nums;
}

Console.WriteLine("Сейчас мы выведем числа и посчитаем сколько больше 0!");

int[] arrayNums = NeedNewNumberArray("Введите числа через пробел");

Console.WriteLine($"Чисел больше 0 в нем: {NumInArrayAfterZero(arrayNums)}");