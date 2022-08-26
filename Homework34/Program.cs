// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Массив заполненный случайными положительными трёхзначными числами:");

int[] MyArray = new int[6];
int Index = 0;
int CountEven = 0;

while (Index < MyArray.Length)
{
    MyArray[Index] = new Random().Next(100, 500);  
    if (MyArray[Index] % 2 ==0) 
    {
        CountEven++;
    }
    Console.Write($"{MyArray[Index]}, ");
    Index++; 
}
Console.WriteLine("\n");
Console.WriteLine($"Колличество четных чисел в данном массиве: {CountEven}");