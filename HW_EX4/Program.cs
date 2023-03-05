// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Enter number more than 2");
int number = Convert.ToInt32(Console.ReadLine());
int current=2;
if(number>1)
    {
    while(current<number)
        {Console.Write(" " +current);
        current+=2;
        }
    }
//else{
    // if(number%2==0){
    //      while(number<1)
    //          {
    //         Console.Write(number);
    //         number=+2;
    //         }
    // }
    // else
    //      number=+1;
    //      while(number<1)
    //          {
    //          Console.Write(number);
    //          number=+2;
    //              }
 //
   // while(number<1)
//        Console.Write(number);
//        number+=2;
//}             
    


