// // Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.Write("Input 5 numbers:  ");
// int number = Convert.ToInt32(Console.ReadLine());
// void Check(int a){

//     string number =a.ToString();
//     if (number[0] == number[4] && number[1]==number[3])
//     {
//         Console.WriteLine($"{number} - is palindrom number");
//     }
//     else Console.WriteLine($"{number} - is NOT palindrom number");
// }

// if(number>9999 && number<100000)
// {
//     Check(number);

// }

// int maxPos = array.Length - 1;
// while(i == maxPos)
// {
   
//     if(number[i]==Array[maxPos])
//     {
//         Console.WriteLine("Число является полиндромом");

//     }
//     i++;
//     int maxPos=-1;

// }






// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 

//и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
double x1, x2, y1, y2, z1, z2, distance;

Console.WriteLine(" Введиите координаты точки a");

Console.Write("Введите координаты x1: ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y1: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z1: ");
z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x2: ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2: ");
y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты z2: ");
z2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(x2 - x1, 2)  + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2));
Console.WriteLine("Расстояние между двумя точками на плоскости равно  " + Math.Round(distance, 2));





// Задача 23

// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число");
// double number = Convert.ToDouble(Console.ReadLine());
// for(int i = 1; i<=number; i++)
// {

//     double CubOfNumber = Math. Pow(i, 3);
//     Console.WriteLine(CubOfNumber);
// }