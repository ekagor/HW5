// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


PrintInfo();
int[] arr2 = RandomArray(4, 100, 999);
PrintArray(4, arr2);
PrintResult();

void PrintInfo()
{
    Console.WriteLine("Программа задает массив заполненный случайными положительными");
    Console.WriteLine("трёхзначными числами и показывает количество чётных чисел в массиве");
}

int[] RandomArray(int lenght, int minValue, int maxValue)
{
    int[] arr1 = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        arr1[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr1;
}

void PrintArray(int lenght, int[] arr2){
    Console.WriteLine("Числа массива: ");
    for (int i = 0; i < lenght; i++){
        Console.Write($"{arr2[i]} ");
    }
}

int Even(int lenght, int[] arr2){
    int count = 0;
    for (int i = 0; i < lenght; i++){
        if (arr2[i] % 2 == 0)
        count++;
    }
    return count;
}

void PrintResult(){
    Console.WriteLine();
    Console.Write($"Количество чётных чисел в массиве: {Even(4, arr2)}");
}