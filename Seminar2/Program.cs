// // Напишите программу, которая выводит случайне число из отрезка [10,99] и показывает
// //наибольшую цифру числа.
// Random rand = new Random();
// int number = rand.Next(10, 100);
// Console.WriteLine("Случайное сгенерированное число это - " + number);
// int max = number / 10;
// int min = number % 10;
// if(max>min)
//     Console.WriteLine("Наибольшая цифра числа это {0}", max);
// else Console.WriteLine("Наибольшая цифра числа это {0}", min);


// Напишите программу, которая выводит рандомное трехзначное число и удаляет втоорую цифру этого
//числа

// Random rand = new Random();
// int number = rand.Next(100, 1000);
// Console.WriteLine("Случайное сгенерированное число это - " + number);
// int a = number/100;
// int b = number%10;
// Console.WriteLine($"{a}{b}");


//Напишите программу , которая принимает на вход два числа 
// //и проверяет, явяялется ли одно квадратом другого
// Console.WriteLine("Введите первое число: ");
// int numberA=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numberB=Convert.ToInt32(Console.ReadLine());
//  if(numberA*numberA==numberB)
//  {
//     Console.WriteLine($"{numberB} является квадратом {numberA}");
//  }
// else{
//      Console.WriteLine($"{numberB} НЕ является квадратом {numberA}");
// }
// if(numberB*numberB==numberA)
//  {
//     Console.WriteLine($"{numberA} является квадратом {numberB}");
//  }
// else{
//      Console.WriteLine($"{numberA} НЕ является квадратом {numberB}");
// }

// Напишите программу, которая принимает на вход два числа и выводит, является ли
// первое число кратным второму. Если число 1 не кратно числу 2, 
// то программа выводит остаток от деления.
// Console.WriteLine("Введите первое число: ");
// int numberA=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int numberB=Convert.ToInt32(Console.ReadLine());
// if(numberA%numberB==0)
//    { Console.WriteLine($"{numberA} кратно {numberB}"); }
//    else{
//     int remainder=numberA%numberB;
//     Console.WriteLine($"{numberA} НЕ кратно {numberB}, остаток: {remainder}");
// }

// ВВести число ои проверить-кратно или нет одновременно 7 и 23
Console.WriteLine("Введите число: ");
int numberA=Convert.ToInt32(Console.ReadLine());
if(numberA%7==0 && numberA%23==0)
    { 
    Console.WriteLine($"{numberA} кратно 7 и 23"); 
    }
else { 
    Console.WriteLine($"{numberA} НЕ кратно 7 и 23"); 
    }