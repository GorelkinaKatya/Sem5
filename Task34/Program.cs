void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(99, 1000);
}

int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
            count++;       
    }
    return count;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество четных чисел в массиве: {CountEvenNumbers(array)}");
