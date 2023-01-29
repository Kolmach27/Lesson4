int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    return Convert.ToInt32(inputValue);
}

int NumberLenght(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int number, int lenght)
{
    int sum = 0;
    for (int i = 1; i <= lenght; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    System.Console.WriteLine(sum);
}

int number = InputInt("Введите число: ");
int lenght = NumberLenght(number);
SumNumbers(number, lenght);
