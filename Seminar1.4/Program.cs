Console.WriteLine("Enter a three-digit number");
int number = Convert.ToInt32(Console.ReadLine());
int lastnum = 0;
if(number>=100 && number<1000)
{
    lastnum = number%10;
    Console.WriteLine(lastnum);
}
else
{
    Console.WriteLine("Enter a three-digit number");
}