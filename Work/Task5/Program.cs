// //Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. 







System.Console.WriteLine("задайте размер массива: ");
int size = 5;
int leftRange = 3;
int rightRange = 5;
int[] array = new int[size];

int[] FillArrayWithRandomNumber(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange);
    }
    return arr;
}

int[] Copyarray(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;

}

int[] firstArray = FillArrayWithRandomNumbers(5, 3, 5); 
Console.WriteLine("[" + string.Join(",", firstArray) +"]"); 
int[] secondArray = CopyArray(firstArray); 
Console.WriteLine("[" + string.Join(",", secondArray) +"]"); 






