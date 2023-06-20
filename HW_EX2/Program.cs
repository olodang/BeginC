//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Enter first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
int number3 = Convert.ToInt32(Console.ReadLine());
int maxNumber=0;
if(number1>maxNumber)
    {
        maxNumber=number1;
        };
if(number2>maxNumber)
    {
        maxNumber=number2;
        };
if(number3>maxNumber)
    {
        maxNumber=number3;
        };
Console.WriteLine($"max number is {maxNumber}");

