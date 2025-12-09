namespace AdventOfCode.Day_4;

public static class Day4
{
    private readonly static string[] fileInput = Reader.ReadInputArrayStrings("Day4Input.txt");

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
            var count = 0;

            var joltage = "";

            var referencePoint = batery[0];

            var startingPoint = 0;

            for (var i = 1; i < batery.Length - 1; i++)
            {
                startingPoint = i;

                if (int.Parse(referencePoint.ToString()) > int.Parse(batery[i].ToString()))
                {
                    joltage = string.Concat(referencePoint);
                    referencePoint = batery[i];
                    break;
                }

                count++;
            }

            for (var i = startingPoint + 1; i < batery.Length - 2; i++)
            {
                if (int.Parse(referencePoint.ToString()) < int.Parse(batery[i].ToString()))
                {
                    joltage += string.Concat(batery[i]);
                    referencePoint = batery[i];
                    continue;
                }

                count++;

                if (count > batery.Length - 12)
                {
                    joltage += string.Concat(batery[i..]);
                    break;
                }
            }

            var total = long.Parse(joltage);
            retValue += total;
        }

        return retValue;
    }
}
