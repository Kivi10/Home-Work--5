// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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
        array[i] = rnd.Next(-10, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int lenght = Promt("Введите число, размер массива");
int[] myArray = CreateArray(lenght);

int result = Sum(myArray);
PrintArray(myArray);
System.Console.WriteLine("Сумма элементов стоящих на нечетных позициях массива = " + result);
