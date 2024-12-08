using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode;

public static class DayOne
{
    public static int GetResponse(string[] input)
    {
        var numbers = GetNumbersOrdered(input);
        
        return GetTotalDistance(numbers);
    }

    private static (int, int)[] GetNumbersOrdered(string[] input)
    {
        var leftNumbers = new int [input.Length];
        var rightNumbers = new int[input.Length];
        
        for (var i = 0; i < input.Length; i++)
        {
            var splitNumbers = input[i].Split("   ");

            leftNumbers[i] = Convert.ToInt32(splitNumbers[0]);
            rightNumbers[i] = Convert.ToInt32(splitNumbers[1]);
        }

        return leftNumbers
            .OrderBy(x => x)
            .Zip(rightNumbers.OrderBy(x => x), (leftNumber, rightNumber) => (leftNumber, rightNumber))
            .ToArray();
    }

    private static int GetTotalDistance((int, int)[] numbers)
    {
        return GetDistances(numbers).Sum();
    }

    private static IEnumerable<int> GetDistances((int, int)[] numbers)
    {
        foreach (var (leftNumber, rightNumber) in numbers)
        {
            yield return GetDistance(leftNumber, rightNumber);
        }
    }
    
    private static int GetDistance(int leftNumber, int rightNumber) => Math.Abs(leftNumber - rightNumber);
}