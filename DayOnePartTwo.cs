using System.Linq;

namespace AdventOfCode;

public static class DayOnePartTwo
{
    public static int GetResponse(string[] input)
    {
        var (leftNumbers, rightNumbers) = Helpers.GetListsOfNumbers(input);

        return GetTotalSimilarity(leftNumbers, rightNumbers);
    }

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