// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.WriteLine("Введите размер массива");

int size =Convert.ToInt32(Console.ReadLine());

int count = 0;


 int [] array = GetArray(size, 100, 999);


int [] GetArray(int size, int minValue, int maxValue )
{

    

    int [] result = new int [size];

    for(int i = 0; i < size; i++)
    {
        result [i] = new Random().Next(minValue, maxValue + 1);      
    }
    return result;
    
}

for (int i = 0; i < size; i++)
{
    if( array[i] %2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"[{String.Join("; ", array)}] количество четных чисел равно {count}");