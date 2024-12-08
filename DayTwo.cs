﻿using System;
using System.Linq;

namespace AdventOfCode;

public static class DayTwo
{
    public static int GetResponse(string[] input)
    {
        var numberOfSafeReports = 0;
        
        foreach (var report in input)
        {
            var numbers = report.Split(" ").Select(x => Convert.ToInt32(x)).ToArray();

            if (IsReportSafe(numbers))
            {
                numberOfSafeReports += 1;
            }
        }

        return numberOfSafeReports;
    }

    private static bool IsReportSafe(int[] numbers)
    {
        var previousStatus = Status.None;
            
        for (int j = 1; j < numbers.Length; j++)
        {
            var i = j - 1;

            var leftNumber = numbers[i];
            var rightNumber = numbers[j];

            if (leftNumber == rightNumber)
            {
                return false;
            }

            var level = rightNumber - leftNumber;

            var currentStatus = DefineStatus(level);

            if (previousStatus == Status.None)
            {
                previousStatus = currentStatus;
                continue;
            }

            if (previousStatus != currentStatus || currentStatus == Status.MoreThanThree)
            {
                return false;
            }
        }
        
        return true;
    }

    private static Status DefineStatus(int level)
    {
        if (Math.Abs(level) > 3)
        {
            return Status.MoreThanThree;
        }

        return level > 0 ? Status.Increasing : Status.Decreasing;
    }

    private enum Status
    {
        None,
        Increasing,
        Decreasing,
        MoreThanThree
    }
}