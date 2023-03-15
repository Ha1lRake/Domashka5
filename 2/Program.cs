// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива");

int size =Convert.ToInt32(Console.ReadLine());

int [] array = GetArray(size);

int [] GetArray(int size)
{
    
    int [] result = new int [size];
    
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(10);
    }
return result;
}

int sum = 0;

for(int i = 0; i < size; i++)
{
    if(i %2 != 0)

    sum += array[i];
}

Console.WriteLine($"Массив [{String.Join("; ", array)}] сумма чисел с  четным индексом равна {sum}");
