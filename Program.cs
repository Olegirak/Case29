
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]
int[] generateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}


string printArray(int[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        string result1 = (array[i] + ",");
        result = result + result1;
    }
    result = result[..^1] + "]";
    return result;
}


int getUserDate(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}


int NumOfArray = getUserDate("Введите число элемнтов массива ");
int LowDiap = getUserDate("Введите нижнюю границу диапазона ");
int UppDiap = getUserDate("Введите верхнюю границу диапазона ");
int[] array = generateArray(NumOfArray, LowDiap, UppDiap);
Console.Write(printArray(array));