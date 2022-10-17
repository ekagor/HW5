// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

PrintInfo();
int lenght = 5;
double[] arr = RandomArray(lenght, 0, 99);
PrintArray(lenght, arr);
PrintResult();

void PrintInfo()
{
    Console.WriteLine("Программа задает массив вещественных чисел");
    Console.WriteLine("и показывает разницу между максимальным и минимальным элементами массива");
}

double[] RandomArray(int lenght, int minValue, int maxValue)
{
    double[] arr1001 = new double[lenght];
    for (int i = 0; i < lenght; i++)
    {
        arr1001[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr1001;
}

void PrintArray(double lenght, double[] arr2){
    Console.WriteLine("Числа массива: ");
    for (int i = 0; i < lenght; i++){
        Console.Write($"{arr2[i]} ");
    }
}

double DiffMinAndMax(double lenght, double[] arr2){
    double max = arr2[0];
    double min = arr2[0];
    for (int i = 1; i < lenght; i++){
        if (arr2[i] > max) max = arr2[i];
        if (arr2[i] < min) min = arr2[i];
    }
    return max-min;
}

void PrintResult(){
    Console.WriteLine();
    Console.Write($"Разница между максимальным и минимальным элементами массива {DiffMinAndMax(lenght, arr)}");
}