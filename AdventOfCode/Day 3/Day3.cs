
using System.Globalization;

namespace AdventOfCode.Day_3;

public static class Day3
{
    private readonly static string[] fileInput = Reader.ReadInputArrayStrings("Day3Input.txt");

    private readonly static string[] localInput = ["987654321111111", "811111111111119", "234234234234278", "818181911112111"];

    private readonly static string[] input = localInput;

    public static int MaximumJoltage()
    {
        var retValue = 0;

        foreach (var batery in input)
        {
            var maxLeft = batery[0];
            var maxRight = batery[batery.Length - 1];

            var skip = 0;

            for (var i = 0; i < batery.Length - 1; i++)
            {
                if (batery[i] > maxLeft)
                {
                    maxLeft = batery[i];
                    skip = i;
                }
            }

            for (var i = batery.Length - 1; i > skip; i--)
            {
                if (batery[i] > maxRight)
                {
                    maxRight = batery[i];
                }
            }

            var total = int.Parse(string.Concat(maxLeft, maxRight));
            retValue += total;
        }

        return retValue;
    }

    public static int MaximumJoltage12Bateries()
    {
        var retValue = 0;

        var joltage = "";

        foreach (var batery in input)
        {
            var count = 0;

            for (var i = 0; i < batery.Length - 1; i++)
            {
                if (int.Parse(batery[i].ToString()) > int.Parse(batery[i + 1].ToString()))
                {
                    joltage += string.Concat(batery[i]);
                    continue;
                }

                count++;

                if(count == 3)
                {
                    joltage += string.Concat(batery[i..]);
                    break;
                }
            }
            var total = int.Parse(joltage);
            retValue += total;
        }

        return retValue;
    }
}
