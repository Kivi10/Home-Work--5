//  Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементов массива.

int Promt(string? message)
{
    System.Console.Write(message + "-> ");
    return int.Parse(Console.ReadLine());
}

double[] CreateArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(50);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
    System.Console.WriteLine();
}

double Difference(double[] array)
{
    double max = array[0];
    foreach (var item in array)
    {
        if (item > max)
        {
            max = item;
        }

    }
    double min = array[0];
    foreach (var item in array)
    {
        if (item < min)
        {
            min = item;
        }
    }
    double diff = max - min;
    return diff;
}

int size = Promt("Введите число, длину массива");
double[] myArray = CreateArray(size);
PrintArray(myArray);
System.Console.WriteLine("Разница между максимальным и минимальным числом массива = " + Difference(myArray));