int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length - 1]}");
    System.Console.WriteLine("]");
}

int length = Prompt("Длинна массива: ");
int min = Prompt("Начальное значение, для диапозона случайного числа: ");
int max = Prompt("Конечное значение, для диапозона случайного числа: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array);

// Объясните работу кода 
// Prompt - запрашивает ввод пользователя, выводя message и возвращая введенное целое число.
// GenerateArray - создает массив случайных целых чисел заданной длины (Length) в заданном диапазоне от minValue до maxValue. Она использует генератор случайных чисел и заполняет массив случайными значениями.
// PrintArray - выводит элементы массива на экран в виде [элемент1, элемент2, ...].
// Далее, код выполняет следующие действия:
// Запрашивает пользователя ввести длину массива (length), начальное значение для диапазона случайных чисел (min) и конечное значение (max) с помощью функции Prompt.
// Затем создает массив с использованием функции GenerateArray, заполняя его случайными числами в указанном диапазоне.
// Наконец, выводит созданный массив на экран с помощью функции PrintArray.
// Таким образом, этот код создает массив случайных чисел заданной длины в указанном диапазоне и выводит его на экран для пользователя.
