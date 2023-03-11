// Первый типа Метода, который не возвращет и не принимает

// void Method1()
// {
//     Console.Writeline("например пишет имя автора");
// }
//так вызывается метод:
//Method1();

//Вторая группа методов, которая ничего не возразает но может принимать какие-то данные

// void Method2(string msg)
// {
//     Console.Writeline(msg);
// }
//Method2("Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i<count)
//     {
//     Console.WriteLine(msg);
//     i++;
//     }
// }
// //Method21("Текст сообщения", 4);
// //Можно также использовать именванные аргументы, тогда их необяхательно записывать по порядку:
// Method21(count:4, msg: "текстик");

// ТРЕТЬЯ ГРУППА методов, которая что-то возвращает, но ничего не принимает
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

//ЧЕТВЕРТАЯ ГРУППА методов, которая и принимает и возвращает

string Method4(int count, string c)
{
    int i=0;
    string result = string.Empty;
    while(i<count)
    {result= result+c;
    i++;
    }
    return result;
}
string res = Method4(10, "qwert");
Console.WriteLine(res);