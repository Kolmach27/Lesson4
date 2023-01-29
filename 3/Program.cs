int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

int Length = InputInt("Введите колличество элементов");
int min = InputInt("Введите минимальное число");
int max = InputInt("Введите максимальное число");

int[] MyArray(int size)
{
    int[] massiv = new int [Length];
    Random rnd = new Random();
    for(int i = 0; i < massiv.Length; i++)
    {
        massiv [i] = rnd.Next(min, max);
    }
    return massiv;
}
void PrintArray(int[] array)
{
       for(int i = 0; i < array.Length; i++)
    {
       System.Console.Write(array [i] + " ");
       if (i != array.Length-1)
            Console.Write(", ");
    }  
}
int[] array =  MyArray(8);
PrintArray(array);