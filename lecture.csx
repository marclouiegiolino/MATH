try
{
    double a = 9.0;
    double b = -3.5;
    //SQUAREROOT
    Console.WriteLine($"Math.Sqrt({a}) is {Math.Sqrt(a)}");

    //ABSOLUTE VALUE
    Console.WriteLine($"Math.Abs({b}) is {Math.Abs(b)}");

    //POWER
    Console.WriteLine($"Math.Pow({a}) , 2) is {Math.Pow(a, 2)}");

    //MAXIMUM
    Console.WriteLine($"Math.Max({a} , b) is {Math.Max(a, b)}");

    //ROW
    Console.WriteLine($"Math.Min({a} , b) is {Math.Min(a, b)}");

    //ROUND
    Console.WriteLine($"Math.Round {3.14159} is {Math.Round(3.14159)}");

    //CEILING
    Console.WriteLine($"Math.Ceiling({3.14}) is {Math.Ceiling(3.14)}");

    //FLOOR
    Console.WriteLine($"Math.Floor({3.99}) is {Math.Floor(3.99)}");


}
catch (Exception ex)
{
    
}