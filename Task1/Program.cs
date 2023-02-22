/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int GetNumber(string messange)
{
Console.WriteLine(messange);
    string number = Console.ReadLine();
    int result = Convert.ToInt32(number);
    return result;
}

int[] InitArray(int dimension)
{
    int[] result = new int[dimension];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = GetNumber($"Введите {i + 1} число");
    }

    return result;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int CountPositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }

    return count;
}

int length = GetNumber("Введите кол-во элементов: ");
int[] arr = InitArray(length);
PrintArray(arr);

Console.WriteLine($"Кол-во чисел больше 0: {CountPositiveNumber(arr)}");


/*

Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"количество значений больше 0 = {sum}");

*/
