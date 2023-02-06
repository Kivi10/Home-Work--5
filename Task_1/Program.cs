// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int Promt(string? message)
{
    System.Console.Write(message + "-> ");
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"{array[i]}\t");
    }
}

bool Check(int size)
{
    if (size <= 0)
    {
        System.Console.WriteLine("Число должно быть положительным и не равнятся нулю");
        return true;
    }
    return false;
}

int Sum(int[] array)
{
    int sum = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

int lenght = Promt("Введите число, размер массива");
int[] myArray = CreateArray(lenght);

int result = Sum(myArray);

if (lenght <= 0)
{
    Check(lenght);
}
else
{
    PrintArray(myArray);
    System.Console.WriteLine($"Число четных числе в массиве = {result}");
}
