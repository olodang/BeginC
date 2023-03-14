// //Напишите программу , которая на вхож принимает координаты точки(x & y),
// // причем Х≠0, y≠0 и выдает номер четверти плоскости, в которой находится эта точка.

// int[] points = new int[2];

// Console.WriteLine("Input X && Y");
// for(int i = 0; i<points.Length; i++)
//     points[i] = Convert.ToInt32(Console.ReadLine());
// if(points[0]>0 && points[1]>0)
//     Console.WriteLine("Это 1-я четверть");
// else if(points[0] < 0 && points[1]>0)
//     Console.WriteLine("Это 2-я четверть");
// // else if(c)
// //     Console.WriteLine("Это 3-я четверть");
// // else if(points[0] > 0 && points[1]<0)
// //     Console.WriteLine("Это 4-я четверть");
// // else Console.WriteLine("x && y =0");


// //Напишите программу, которая по заданному номеру четверти показывает 
// //диапазон возможных координат точек в этой четверти(х и y).

// Console.WriteLine("Введите номер четверти");
// int numberOfquarter = Convert.ToInt32(Console.ReadLine());
// if(numberOfquarter== 1)
// {
//     Console.WriteLine("X>0 && Y>0");
// }
// else if(numberOfquarter== 2)
// {
//     Console.WriteLine("X< 0 && Y>0");
// }
// else if(numberOfquarter== 3)
// {
//     Console.WriteLine("X< 0 && Y>0");
// }
// else if(numberOfquarter== 4)
// {
//     Console.WriteLine("X>0 && Y>0");
// }
// // else
// {
//     Console.WriteLine("некорректное число");
// }


// напишите пограмму, которая принимает на вход число (N) и 
// //выдает таблицу квадратов чисел от 1 до N

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i<=number; i++)
// {
//     int quarter = i*i;
//     Console.WriteLine(quarter+ "\t");
// }

//вычислить расстояние между двумя точками на плоскости

double x1, x2, y1, y2, distance;

Console.WriteLine(" Введиите координаты точки a");

Console.Write("Введите координаты x1: ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y1: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты x2: ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты y2: ");
y2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("Расстояние между двумя точками на плоскости равно  " + Math.Round(distance, 2));

