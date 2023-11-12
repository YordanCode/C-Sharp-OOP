
using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sum = 0;

        string[] elements = input.Split();

        foreach (string element in elements)
        {
            try
            {
                sum += int.Parse(element);
            }
            catch (FormatException)
            {
                Console.WriteLine($"The element '{element}' is in wrong format!");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"The element '{element}' is out of range!");
            }
            finally
            {
                Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
            }
        }

        Console.WriteLine($"The total sum of all integers is: {sum}");
    }
}

