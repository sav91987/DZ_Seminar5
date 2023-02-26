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
        result[i] = new Random().Next(minValueMeth, maxValueMeth+1);
    }
    return result;
}

if (minValue < 0 || minValue < 100 || maxValue < 0 || maxValue > 999 || minValue >= maxValue)
{
    System.Console.WriteLine("Задан некорректный диапазон. Введите значения из диапазона [100, 999]");
}
else
{
    int[] array = GetArray(length, minValue, maxValue);
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }

    System.Console.WriteLine($"[{String.Join("; ", array)}]");
    System.Console.WriteLine($"Число четных элементов равно: {count}");
}





// int GetPositiveNumbers(int array, int size)
// {
// for (int i = 0; i < length; i++)
// {

// }
// }








// int[] array = GetArray(123,0,100);
// int length = array.Length;
// System.Console.WriteLine($"[{String.Join("; ",array)}]");

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result =new int[size];
//     for (int i = 0; i < size; i++)
// {
//     result[i] = new Random().Next(minValue, maxValue+1);
// }
// return result;
// }

// int count =0;
// for (int i = 0; i < length; i++)
// {
//    if ((array[i] >= 10) && (array[i] <= 99))
//    {
//         count++;
//    } 
// }
// System.Console.WriteLine(count);
