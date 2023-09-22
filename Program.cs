using System;

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}
int Power(int powerBase, int exponent)
{
    if (exponent == 0)
    {
        return 1; // Любое число в нулевой степени равно 1.
    }
    int result = 1;
    for (int i = 0; i < exponent; i++)
    {
        result *= powerBase; // Умножаем основание на себя exponent раз.
    }
    return result;
}

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        System.Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}
int powerBase = Prompt("Введите основание:");
int exponent = Prompt("Введите показатель:");
if (ValidateExponent(exponent))
{
    System.Console.Write($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}