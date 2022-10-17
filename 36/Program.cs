// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

PrintInfo();
int[] arr = RandomArray(4, -99, 99);
PrintArray(4, arr);
PrintResult();

void PrintInfo()
{
    Console.WriteLine("Программа задает одномерный массив, заполненный случайными числами");
    Console.WriteLine("и показывает сумму элементов, стоящих на нечётных позициях");
}

int[] RandomArray(int lenght, int minValue, int maxValue)
{
    int[] arr2 = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        arr2[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr2;
}

void PrintArray(int lenght, int[] arr2){
    Console.WriteLine("Числа массива: ");
    for (int i = 0; i < lenght; i++){
        Console.Write($"{arr2[i]} ");
    }
}

int SumNumOddPositions(int lenght, int[] arr2){
    int sum = 0;
    for (int i = 0; i < lenght; i++){
        if (i % 2 == 0);
        else sum = sum + arr2[i];
    }
    return sum;
}

void PrintResult(){
    Console.WriteLine();
    Console.Write($"Сумма элементов, стоящих на нечётных позициях: {SumNumOddPositions(4, arr)}");
}