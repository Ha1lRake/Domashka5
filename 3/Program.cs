// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.WriteLine("Введите размер массива");

int size = Convert.ToInt32(Console.ReadLine());

int [] array = GetArray(size);

int [] GetArray(int size)
{
    int [] result = new int [size];

    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}

int min = array[0];
int max = array[0];

for(int i = 0; i < size; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    else if (array[i] < min)
    {
        min = array[i];
    }

}

int difference = max - min;


Console.WriteLine($"Разница между максимальным числом {max} и минимальным {min} из массива [{String.Join("; ", array)}] равна {difference}");