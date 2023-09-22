int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        int digit = number % 10; // Получаем последнюю цифру числа.
        result += digit; // Добавляем цифру к результату.
        number /= 10; // Убираем последнюю цифру из числа.
    }
    return result;
}

int number = Prompt("Введите число:");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllDigit(number)}");

