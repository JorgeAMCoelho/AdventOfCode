using System.Collections;

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

    public static long MaximumJoltage12Bateries()
    {
        var retValue = 0l;

        foreach (var batery in input)
        {
            var joltage = new Stack();

            var joltageResult = "";

            joltage.Push(batery[0]);

            for (var i = 1; i < batery.Length; i++)
            {
                while (joltage.Count > 0 && int.Parse(joltage.Peek().ToString() ?? "0") < int.Parse(batery[i].ToString()))
                {
                    if (joltage.Count + batery[i..].Length <= 12)
                    {
                        break;
                    }

                    joltage.Pop();
                }

                joltage.Push(batery[i]);
            }

            while (joltage.Count != 12)
            {
                joltage.Pop();
            }

            joltageResult = string.Join("", joltage.ToArray().Reverse());

            var total = long.Parse(joltageResult);

            retValue += total;
        }

        return retValue;
    }
}
