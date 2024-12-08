using System;

namespace AdventOfCode;

public static class Helpers
{
    public static (int[] leftNumbers, int[] rightNumbers) GetListsOfNumbers(string[] input)
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
}