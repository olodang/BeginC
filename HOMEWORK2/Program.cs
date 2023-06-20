// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите число: ");
// int number=Convert.ToInt32(Console.ReadLine());
// if(number>99 && number<1000)
// {
//     int a = number/100;
//     int b = number%10;
//     int c = ((number-a*100)-b)/10;
//     Console.WriteLine($"{c}");
// }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
// Console.WriteLine("Введите число: ");
// int number=Convert.ToInt32(Console.ReadLine());
// int remainder= number/100;
//  if(remainder<1){
//     Console.WriteLine("Третьей цифры не существует"); 
//  }
//  else{
//     Console.WriteLine($"{remainder}"); 
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int number=Convert.ToInt32(Console.ReadLine());
if(number== 6 || number == 7)
{
    Console.WriteLine("Это выходной день"); }
else if(number==5){
    Console.WriteLine("Это выходной день у евреев и мусульман"); }
else {
    Console.WriteLine("Это рабочий день для цивилизванного большинства");
}
