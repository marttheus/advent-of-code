using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode;

public static class DayOne
{
    public static int GetPartOneResponse(string[] input)
    {
        var numbers = GetNumbersOrdered(input);
        
        return GetTotalDistance(numbers);
    }
    
    public static int GetPartTwoResponse(string[] input)
    {
        var (leftNumbers, rightNumbers) = GetListsOfNumbers(input);

        return GetTotalSimilarity(leftNumbers, rightNumbers);
    }
    
    private static (int[] leftNumbers, int[] rightNumbers) GetListsOfNumbers(string[] input)
    {
        var leftNumbers = new int [input.Length];
        var rightNumbers = new int[input.Length];
        
        for (var i = 0; i < input.Length; i++)
        {
            var splitNumbers = input[i].Split("   ");

            leftNumbers[i] = Convert.ToInt32(splitNumbers[0]);
            rightNumbers[i] = Convert.ToInt32(splitNumbers[1]);
        }

        return (leftNumbers, rightNumbers);
    }

    private static (int, int)[] GetNumbersOrdered(string[] input)
    {
        var (leftNumbers, rightNumbers) = GetListsOfNumbers(input);

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

    private static int GetTotalSimilarity(int[] leftNumbers, int[] rightNumbers)
    {
        var totalSimilarity = 0;
        
        foreach (var leftNumber in leftNumbers)
        {
            var appears = rightNumbers.Count(rightNumber => rightNumber == leftNumber);

            totalSimilarity += appears * leftNumber;
        }

        return totalSimilarity;
    }
}