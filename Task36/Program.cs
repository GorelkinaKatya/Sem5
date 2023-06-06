void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void CountNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i != 0 && i % 2 != 0)
            sum += array[i];       
    }
    Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
CountNumbers(array);