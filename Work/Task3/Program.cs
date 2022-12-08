// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины. 
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон. 

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 45 -> 101101 3 -> 11 2 -> 10 

/*
int DataInput(string str)
{
    System.Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void Treugolnik(int a, int b, int c)
{
    if (a + b < c || a + c < b || b + c < a)
    {
       Console.WriteLine("это треугольник ");
    }

}
int a = DataInput("укажите длинну стороны a ");
int b = DataInput("укажите длинну стороны b ");
int c = DataInput("укажите длинну стороны c ");
Treugolnik(a, b, c);
*/

System.Console.WriteLine("введите число ");
int N = int.Parse(Console.ReadLine());
GetBinaryView(N);

void GetBinaryView(int number)
{
    if (number <= 0)
    {
        return;
    }
    GetBinaryView(number / 2);
    System.Console.Write(number % 2);
}