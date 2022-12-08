// Задайте массив из 12 заполнеYfнный случайными числами из промежутка [-9, 9]
// Найдите суппу отрицательных и положительных элементов 

Console.Clear();

int[] array = new int[12];
Random rand = new Random();

int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}
Console.WriteLine('[' + string.Join(", ", array) + ']');

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sumPositive = sumPositive + array[i];  //sumPositive += array[i]- короткая запись 
    }
    else
    {
        sumNegative = sumNegative + array[i];  //sumNegative += array[i];
    }

}
Console.WriteLine("Сумма положительных элементов = " + sumPositive + " Сумма отрицательных элементов  = " + sumNegative);

/*

System.Console.WriteLine("задайте размер массива: ");
int size = int.Parse(Console.ReadLine());
int leftRange = -10;
int rightRange = 100;
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

array = FillArrayWithRandomNumber(size, leftRange, rightRange);
Console.Write("[" + string.Join(", ", array) + "]");

*/