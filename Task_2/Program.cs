//Методы рабочие
Random rand = new Random();
void PrintArrayDouble(double[] tempArray)
{
    Console.Write("[" + string.Join(", ", tempArray) + "]");
}

//Методы для домашнего задания
double[] userConsoleInputDouble()
{
    return Array.ConvertAll(Console.ReadLine()!.Split(), double.Parse);
}
double[] pointOfCross2Straights(double[] tempArray){
    double[] pointOfCross = new double[2];
    pointOfCross[0] = -1 * ((tempArray[0] - tempArray[2]) / (tempArray[1] - tempArray[3]));
    pointOfCross[1] = -1 * (tempArray[1]*( -1 * pointOfCross[0]) - tempArray[0]);
    return pointOfCross;
}
//Задача 41: Пользователь вводит
//с клавиатуры M чисел. Посчитайте
//, сколько чисел больше 0
//ввёл пользователь.
//5
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Write("Введите числа в формате b1 k1 b2 k2: ");
double[] equationArray = userConsoleInputDouble();
PrintArrayDouble(pointOfCross2Straights(equationArray));