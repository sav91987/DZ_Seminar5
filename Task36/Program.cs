System.Console.WriteLine("Задайте число элементов массива");
int length = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Задайте нижнюю границу диапазона чисел массива:");
int minValue = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Задайте верхнюю границу диапазона чисел массива:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int size, int minValueMeth, int maxValueMeth)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValueMeth, maxValueMeth + 1);
    }
    return result;
}

int[] array = GetArray(length, minValue, maxValue);
int sum = 0;

for (int i = 1; i < length; i += 2)
{
    sum += array[i];
}

System.Console.WriteLine($"[{String.Join("; ", array)}]");
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");