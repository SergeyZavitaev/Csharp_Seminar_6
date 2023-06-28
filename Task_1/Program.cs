//Методы рабочие
Random rand = new Random();
void PrintArray(int[] tempArray)
{
    Console.Write("[" + string.Join(", ", tempArray) + "]");
}

//Методы для домашнего задания
int[] userConsoleInputInt()
{
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}
int CountPositNumInArray(int[] tempArray)
{
    int posNmAmount = 0;
    for (int i = 0; i < tempArray.Length; i++)
        if(tempArray[i]>0)
            posNmAmount+=1;
    return posNmAmount;
}

//Задача 41: Пользователь вводит
//с клавиатуры M чисел. Посчитайте
//, сколько чисел больше 0
//ввёл пользователь.
//5
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

//userConsoleInput
int[] array = userConsoleInputInt();
PrintArray(array);
Console.Write($" -> {CountPositNumInArray(array)}");