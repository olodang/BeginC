Console.WriteLine("Введите число");
int MaxNumber = Convert.ToInt32(Console.ReadLine());
int MinNumber = MaxNumber * -1;
while(MinNumber<=MaxNumber)
   {
    Console.WriteLine(MinNumber);
    MinNumber+=1;
   }