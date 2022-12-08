// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. 
//Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1 Если N = 7 -> 0 1 1 2 3 5 8 






int DataInput(string str)
{
    System.Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] ConvertToF(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int index = 2; index < num; index++)
    {
        array[index] = array[index - 2] + array[index - 1];
    }
    return array;
}
int a = DataInput("введите число ");
int[] arr = ConvertToF(a);
Console.WriteLine("[" + string.Join(",", arr) + "]");


