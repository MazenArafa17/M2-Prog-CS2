using System;
using System.Collections.Generic;

namespace _04_lists;

class RemoveExample
{
    public void Run()
    {
        List<double> numbers = new List<double> { 9.99, 4.68, 342.97, 12.2 };

        Console.WriteLine("Original nummers:");
        foreach (var n in numbers) Console.WriteLine(n);

        double max = double.MinValue;
        foreach (var n in numbers) if (n > max) max = n;
        numbers.Remove(max);

        Console.WriteLine();
        Console.WriteLine($"After Remove(max={max}):");
        foreach (var n in numbers) Console.WriteLine(n);

        if (numbers.Count > 0) numbers.RemoveAt(0);

        Console.WriteLine();
        Console.WriteLine("After RemoveAt(0):");
        foreach (var n in numbers) Console.WriteLine(n);
    }
}