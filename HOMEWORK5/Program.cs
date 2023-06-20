// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// int [] CreateArray(int size)
// {
//     int [] array = new int [size];
//     for (int i=0; i<size; i++)
//     array [i] = new Random().Next(100,1000);
//     return array;
// }
// int CountEven (int[] array)
// {   int count = 0;
//     for (int i=0; i<array.Length; i++)
//         if(array[i]%2==0)
//             count=count+1;
//     return count;
// }
// int[] NewArray = CreateArray(4);
// Console.WriteLine(string.Join(", ", NewArray));
// int count =  CountEven(NewArray);
// Console.WriteLine($"{count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// int [] CreateArray(int size)
// {int [] array = new int [size];
//     for (int i=0; i<size; i++)
//         array [i] = new Random().Next(100,1000);
// return array;
// }
// int SumOdd (int[] array)
// {int sum =0;
//     for(int i=0; i<array.Length; i+=2)
//     sum = sum+array[i];
//  return sum;
// }
// int[] Array = CreateArray(5);
// Console.WriteLine(string.Join(", ", Array));
// int a = SumOdd(Array);
// Console.WriteLine($"{a}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
double[] array = {10,6,2,9,6,4,3};
double MinNumber(double[] array)
{
    int min = 0;
    for(int i=1; i< array.Length; i++)
        if(array[min]>array[i])
            min = i;
return array[min];
}
double MaxNumber(double[] array)
{   int max = 0;
    for(int i =1; i <array.Length; i++)
        if (array[max]<array[i])
        max = i;
    return array[max];
}
double a = MaxNumber(array);
double b = MinNumber(array);
double diff = a-b;

Console.WriteLine($"{a}");
Console.WriteLine($"{b}");
Console.WriteLine($"{diff}");
