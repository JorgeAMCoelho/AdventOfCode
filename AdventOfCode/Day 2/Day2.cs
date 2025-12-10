namespace AdventOfCode.Day_2;

public static class Day2
{
    private readonly static string fileInput = Reader.ReadInputStrings("Day2Input.txt");

    private readonly static string localInput = "11-22,95-115,998-1012,1188511880-1188511890,222220-222224,1698522-1698528,446443-446449,38593856-38593862,565653-565659,824824821-824824827,2121212118-2121212124";

    private readonly static string input = fileInput;

    public static long InvalidIds()
    {
        long idsSum = 0;

        var separatedRanges = input.Split(',');

        for (int i = 0; i < separatedRanges.Length; i++)
        {
            var ranges = separatedRanges[i].Split("-");

            var lowerRange = long.Parse(ranges[0]);
            var upperRange = long.Parse(ranges[1]);

            while (lowerRange <= upperRange)
            {
                var value = lowerRange.ToString();

                var fistHalf = value.Substring(0, (value.Length + 1) / 2);
                var secondHalf = value.Substring((value.Length + 1) / 2);

                if (fistHalf == secondHalf)
                {
                    idsSum += lowerRange;
                }

                ++lowerRange;
            }
        }

        return idsSum;
    }

    public static long InvalidIdsPartTwo()
    {
        long idsSum = 0;

        var separatedRanges = input.Split(',');

        for (int i = 0; i < separatedRanges.Length; i++)
        {
            var ranges = separatedRanges[i].Split("-");

            var lowerRange = long.Parse(ranges[0]);
            var upperRange = long.Parse(ranges[1]);

            while (lowerRange <= upperRange)
            {
                var value = lowerRange.ToString();

                var compareValue = value[0].ToString();

                var toAdd = false;

                var length = compareValue.Length;

                for (var j = 1; j < value.Length; j++)
                {
                    if (j + length > value.Length)
                    {
                        if (value.Substring(j).Length > 0)
                        {
                            toAdd = false;
                        }
                        break;
                    }

                    var toBeCompared = value.Substring(j, length);

                    if (compareValue == toBeCompared)
                    {
                        j = j + length - 1;
                        toAdd = true;
                        continue;
                    }

                    compareValue = value.Substring(0, j + 1);
                    length = compareValue.Length;
                    toAdd = false;
                }

                if (toAdd)
                {
                    idsSum += lowerRange;
                }

                ++lowerRange;
            }
        }

        return idsSum;
    }
}
