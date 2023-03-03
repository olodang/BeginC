Console.WriteLine("Enter number");
int MaxNumber = Convert.ToInt32(Console.ReadLine());
int MinNumber = -MaxNumber;
Console.WriteLine("Вывод целых чисел");
while(MinNumber<=MaxNumber)
{
    Console.Write(" "+MinNumber);
    MinNumber +=1;
}
