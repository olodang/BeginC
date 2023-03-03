int number = Convert.ToInt32(Console.ReadLine());
//if(number==3)
//{
//    Console.WriteLine("СРЕДА");
//}
//else if(number==5)
//{
  //  Console.WriteLine("ПЯТНИЦА");
//}
//else 
//{
 //   Console.WriteLine($"{number}");
//}

switch(number)
{
    case 3:
       Console.WriteLine("СРЕДА");
       break;
    case 5:
        Console.WriteLine("ПЯТНИЦА");
        break;
    default: Console.WriteLine($"{number}");
    break;
}
