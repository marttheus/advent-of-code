using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode;

public static class DayThree
{
    public static int GetPartOneResponse(string[] input)
    {
        var result = 0;
        
        foreach (var line in input)
        {
            var numbersToMultiply = GetNumbersToMultiply(line);

            foreach (var (leftNumber, rightNumber) in numbersToMultiply)
            {
                result += leftNumber * rightNumber;
            }
        }
        
        return result;
    }

    private static (int, int)[] GetNumbersToMultiply(string line)
    {
        const string regexPattern = @"mul\((\d+),(\d+)\)";
        
        var matches = Regex.Matches(line, regexPattern);

        var numbers = new (int, int)[matches.Count];

        for (var i = 0; i < matches.Count; i++)
        {
            var x = Convert.ToInt32(matches[i].Groups[1].Value);
            var y = Convert.ToInt32(matches[i].Groups[2].Value);

            numbers[i] = (x, y);
        }

        return numbers;
    }
}