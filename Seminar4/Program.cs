// Напишите программу, которая принимает на вход число (A) и выдает сумму чисел от 1 до A.
//7-->28
//4-->10
//8-->36
// int Prompt()
// {
//     Console.WriteLine("Введите число");
//     return Convert.ToInt32(Console.ReadLine());
// }
// int SumNums(int number)
// {
//     int sum = 0;
//     for (int i=1; i<=number; i++)
//     sum+=i;
//     return sum;
// }

// int a = Prompt();
// Console.WriteLine(SumNums(a));


// Напишите программу, которая на вход принимает массив из 8 элементов, заполненный нулями
// и еденицами в случайном порядке.

int Prompt()
    {Console.WriteLine("Введите количество");
    return Convert.ToInt32(Console.ReadLine());}

int [] CreateArray(int size)
{ 
    int[] array = new int [size];
    for (int i=0; i<size; i++){
        array[i] = new Random().Next(0,2);
} return array;
}

int[] newArray = CreateArray(Prompt());
Console.WriteLine($"[{string.Join(", ", newArray)}]");
