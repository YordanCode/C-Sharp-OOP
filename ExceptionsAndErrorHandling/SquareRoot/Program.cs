using System;
try
{
    int number = int.Parse(Console.ReadLine());
    if (number < 0)
    {
        throw new InvalidOperationException("Invalid number.");
    }
    else
    {
        int squareRoot = (int)Math.Sqrt(number);
        Console.WriteLine(squareRoot);
    }
}
catch (FormatException)
{
    throw new FormatException("Invalid number.");
}
catch (InvalidOperationException)
{
    throw new InvalidOperationException("Invalid number.");
}
finally
{
    Console.WriteLine("Goodbye.");
}

