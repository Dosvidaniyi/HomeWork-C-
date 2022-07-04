// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число:  ");
// int num = int.Parse(Console.ReadLine());

// int sum = 0;

// for (int i = 1; i <= num; i++) 
// {
//     sum = sum + i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {num}= {sum}");

// int Sum(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         sum = sum + i;
//     }
//     return sum;
// }
// int result = Sum(num);
// Console.WriteLine($"Сумма чисел от 1 до {num}= {result}");

// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число:  ");
// int num = int.Parse(Console.ReadLine());
// int count = 0;
// while (num != 0)
// {
//     num /= 10;
//     count++;
//     // Console.WriteLine(num%10);
// }
// Console.WriteLine($"Количество цыфр в числе = {count}");

// void Fact(int namber)
// {
// 	int temp = 1;
// 	for (int i = 1; i <= namber; i++)
// 	{
// 		temp *= i;
// 	}
// 	Console.WriteLine(temp);
// }

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// Fact(num);

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.WriteLine("Введите N: ");
int num = int.Parse(Console.ReadLine());

int[] FillArray(int num)
{
    int[] array = new int[num];
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0, 2);
        index++;
    }
    return array;
}

void PrintArray(int[] col)
{
    Console.Write("[");
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
    Console.Write("]");
}

int[] arr = FillArray(num);
PrintArray(arr);
