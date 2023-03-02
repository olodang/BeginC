int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int squareB = numberB * numberB;
if(squareB == numberA)
    {
        Console.WriteLine($"yes, {numberA} is a square for {numberB}");
    }
else 
    {
        Console.WriteLine($"{numberA} isn`t square for {numberB}");
    }

