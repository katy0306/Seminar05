//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int n = new Random().Next(2,11); 
double[] array = new double [n];

void FillPrintDouble(double[] arr) 
{
    double min = -100;
    double max = 100;
    double range = max - min;
    for (int i = 0; i < arr.Length; i++)
    {
        double sample = new Random().NextDouble();
        double scaled = (sample * range) + min;
        arr[i] = Math.Round(scaled,2);
        Console.Write(arr[i] + "   ");

    }
    Console.WriteLine();
    Console.WriteLine();
}


double MinMaxDiff (double [] arr)
{
    double diff = 0;
    double min = arr[0];
    double max = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    diff = max - min;
    return diff;
}

FillPrintDouble(array);

Console.WriteLine($"Разница между максимальными и минимальными элементами массива: {MinMaxDiff(array)}");
Console.WriteLine();