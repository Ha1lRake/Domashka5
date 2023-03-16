// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.WriteLine("Введите размер массива");

int size = Convert.ToInt32(Console.ReadLine());

double [] array = GetArray(size);

double [] GetArray(int size)
{
    double [] result = new double [size];

    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * 100 ;
    }
    return result;
}

double min = array[0];
double max = array[0];

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

double difference = max - min;


Console.WriteLine($"Разница между максимальным числом {max} и минимальным {min} из массива [{String.Join("; ", array)}] равна {difference}");