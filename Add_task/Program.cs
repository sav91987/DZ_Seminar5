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

int newLength = 0;
if (length % 2 == 0)
    newLength = length / 2;
else newLength = length / 2 + 1;

int[] array = GetArray(length, minValue, maxValue);

int[] GetResultArray(int size, int newSize, int[] array)
{
    int sizeSaved = size;
    int[] resultArray = new int[newSize];

    for (int i = 0; i < newSize; i++)
    {
        resultArray[i] = array[i] * array[size - 1];
        Console.WriteLine(resultArray[i]);
        size--;
    }
    Console.WriteLine(newSize % 2);
    if ((sizeSaved % 2) != 0)
    {
        resultArray[newSize - 1] = array[newSize - 1];
    }
    return resultArray;
}
int[] newArray = GetResultArray(length, newLength, array);

System.Console.WriteLine($"[{String.Join("; ", array)}]");
System.Console.WriteLine($"[{String.Join("; ", newArray)}]");

