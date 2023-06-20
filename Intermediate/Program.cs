// 66
int NaturalSum(int M, int N)
{
    if (M==N) return M;
    return N +NaturalSum(M, N-1);
}
Console.WriteLine("Введите два числа");
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int sum = NaturalSum(M,N);
Console.WriteLine($"сумма чисел от M до N равна {sum}");

//68

Console.WriteLine("Введите начальное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

int Ackermann (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return Ackermann(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return Ackermann(numberM - 1, Ackermann(numberM, numberN - 1));
return Ackermann (numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {Ackermann(numberM, numberN)}");