Console.Clear();

double[] pointA = new double[3];
double[] pointB = new double[3];
string[] txtCoor = {"x","y","z"};

double NeedNewDoubleNum() {
    double num = 0;
    bool entered = false;
    while (!entered) {
        try {
            Console.Write("");
            num = double.Parse(Console.ReadLine());
            entered = true;
        } catch {
            Console.WriteLine("Вы ввели не число! Пожалуйста повторите ввод.");
        }
    }
    return num;
}
void ShowDistance(double[] p1, double[] p2) {
    double dist = Math.Sqrt(Math.Pow(p1[0]-p2[0],2)+Math.Pow(p1[1]-p2[1],2)+Math.Pow(p1[2]-p2[2],2));
    Console.WriteLine($"Расстояние между нашими точками [{string.Join(", ",pointA)}] и [{string.Join(", ",pointB)}] равно {dist} или {Math.Round(dist,2)}");
}

Console.WriteLine("Сейчас мы найдем расстояние между двумя точками в 3-ёхмерном пространстве!");

for(int i=0;i<pointA.Length;i++){
    Console.Write($"Введите координату {txtCoor[i]} первой точки: ");
    pointA[i] = NeedNewDoubleNum();
}
for(int i=0;i<pointB.Length;i++){
    Console.Write($"Введите координату {txtCoor[i]} второй точки: ");
    pointB[i] = NeedNewDoubleNum();
}

ShowDistance(pointA, pointB);