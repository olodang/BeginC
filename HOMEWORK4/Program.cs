// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int Prompt()
// {
// Console.WriteLine("Input number");
// return Convert.ToInt32(Console.ReadLine());
// }

// int Pow(int a, int b)
// {
//     int result = 1;

//     for(int mp= 0; mp<b; mp++)
//     {
//         result = a* result;
//     }
// return result;
// }
// int a = Prompt(); int b = Prompt();
// Console.WriteLine(Pow(a,b));




// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// // 452 -> 11

// // 82 -> 10

// // 9012 -> 12

// int Prompt()
//     {
//         Console.WriteLine("Input number");
//         return Convert.ToInt32(Console.ReadLine());
//     }
// int SumOfDigits(int num)
//     {
//         int sum = 0;
//         while(num>0)
//         {sum = num%10+sum;
//         num/=10;
//         }
//     return sum;
//     }

// int num=Prompt();
// Console.WriteLine(SumOfDigits(num)); 


// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// // 6, 1, 33 -> [6, 1, 33]
int Prompt()
    {
        Console.WriteLine("Input number");
        return Convert.ToInt32(Console.ReadLine());
    }
int[] CreateArray(int size)
{
    int[]array = new int[size];
    for (int i = 0; i<size; i++)
    {
    array[i] = new Random().Next(0,100);
    }
    return array;
}
int []newArray = CreateArray(Prompt());
Console.WriteLine($"[{string.Join(",  ", newArray)}]");

