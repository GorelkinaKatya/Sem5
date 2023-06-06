void InputArray(double[] array)
{
    int end = 10, begin = 0;
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * (end - begin) + begin, 2);
}

void MaxMinDiff(double[] array)
{
    double max = array[0], min = array[0];
    foreach (double element in array)
    {
        if (element > max)
            max = element;       
    }
    foreach (double element in array)
    {
        if (element < min)
            min = element;       
    }
    Console.WriteLine($"{max} - {min} = {Math.Round(max - min, 2)}");
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
MaxMinDiff(array);