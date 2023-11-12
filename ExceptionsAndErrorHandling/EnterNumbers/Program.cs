using System;
using System.Collections.Generic;

List<int> numbers = new();
void ReadNumbers(int start, int end)
{
    try
    {
        int number = int.Parse(Console.ReadLine());
        if (number > start && number < end)
            numbers.Add(number);
        else
            throw new InvalidOperationException($"Your number is not in range {start} - 100!");
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid Number!");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
int start = 1;
while (numbers.Count < 10)
{
    if (numbers.Count > 0)
        start = numbers[numbers.Count - 1];
    ReadNumbers(start, 100);
}
Console.WriteLine(string.Join(", ", numbers));

    

