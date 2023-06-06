void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}

int CountEvenNumbers(int[] array)
{
    int count1 = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0)
        {
            Console.Write($"{element} ");
            count1++;       
        }
    }
    Console.WriteLine();
    return count1;
}

int CountOddNumbers(int[] array)
{
    int count2 = 0;
    foreach (int element in array)
    {
        if (element % 2 != 0)
        {
            Console.Write($"{element} ");
            count2++;       
        }
    }
    Console.WriteLine();
    return count2;
}

string CountResult(int count1, int count2)
{
    if (count1 <= count2)
        return "YES";
    else return "NO";
}


Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Массив: [{string.Join(" ", array)}]");
Console.WriteLine(CountResult(CountOddNumbers(array), CountEvenNumbers(array)));