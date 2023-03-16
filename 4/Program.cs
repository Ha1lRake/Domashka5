// Доп. задачка:
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.WriteLine("Введите размер массива");

int size = Convert.ToInt32(Console.ReadLine());

int[] array = MagicMetod(size);

int[] MagicMetod(int size)
{
    int[] MagicResult = new int[size];

    for (int i = 0; i < size; i++)
    {
        MagicResult[i] = new Random().Next(1, 10);
    }
    return MagicResult;
}

Console.Write($"Массив -> [{String.Join("; ", array)}] ");

int result = array[0];

for (int i = 0; i < size / 2; i++)
{
    result = array[i] * array[size - i - 1];
    Console.Write($"произведение {array[i]} на {array[size - i - 1]} = {result}  ");
    

}
if(size %2 ==1)
    {
        Console.Write("число посередине - " + array[size/2]);
    } 



