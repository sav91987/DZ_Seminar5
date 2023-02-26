System.Console.WriteLine("Задайте число элементов массива");
int length = Convert.ToInt32(Console.ReadLine());

double[] GetArray(int size)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return result;
}

double[] array = GetArray(length);

double sum = GetMaxMin(length, array);
double GetMaxMin(int size, double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    return max + min;
}

System.Console.WriteLine($"[{String.Join("; ", array)}]");
System.Console.WriteLine($"Сумма максимального и минимального элементов равна: {sum}");