

using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading;

namespace PlayCatch;
internal class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).
                        Select(int.Parse).ToArray();
        int count = 0;
        while (count < 3)
        {
            string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = tokens[0];
            try
            {
                int index = int.Parse(tokens[1]);
                if (command == "Replace")
                {
                    int element = int.Parse(tokens[2]);
                    Replace(numbers, index, element);
                    //numbers[index] = element;
                }
                else if (command == "Print")
                {
                    int endIndex = int.Parse(tokens[2]);
                    Print(numbers, index, endIndex);
                }
                else if (command == "Show")
                    Show(numbers, index);
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The index does not exist!");
                count++;
            }
            catch (FormatException)
            {
                Console.WriteLine("The variable is not in the correct format!");
                count++;
            }
        }
        Console.WriteLine(string.Join(", ", numbers));
    }

    static void Replace(int[] numbers, int index, int value)
       => numbers[index] = value;
    static void Print(int[] numbers, int startIndex, int endIndex)
    {
        if (startIndex < 0 || startIndex > numbers.Length - 1
                    || endIndex < 0 || endIndex > numbers.Length - 1)
            throw new IndexOutOfRangeException();

        int[] subArray = numbers.Skip(startIndex).Take(endIndex - startIndex + 1).ToArray();
        Console.WriteLine(string.Join(", ", subArray));
    }
    static void Show(int[] numbers, int index)
        => Console.WriteLine(numbers[index]);
}
