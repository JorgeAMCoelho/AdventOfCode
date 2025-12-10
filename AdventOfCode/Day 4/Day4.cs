namespace AdventOfCode.Day_4;

public static class Day4
{
    private readonly static string[] fileInput = Reader.ReadInputArrayStrings("Day4Input.txt");

    private readonly static string[] localInput = ["..@@.@@@@.", "@@@.@.@.@@", "@@@@@.@.@@", "@.@@@@..@.", "@@.@@@@.@@", ".@@@@@@@.@", ".@.@.@.@@@", "@.@@@.@@@@", ".@@@@@@@@.", "@.@.@@@.@."];

    private readonly static string[] input = localInput;

    public static int AccessByForklift()
    {
        var retValue = 0;

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input.Length; j++)
            {
                var hasAdjacent = 0;

                if (input[i][j] == '@')
                {
                    if (j - 1 >= 0)
                    {
                        if (input[i][j - 1] == '@')
                            ++hasAdjacent;
                    }

                    if (j + 1 < input.Length)
                    {
                        if (input[i][j + 1] == '@')
                            ++hasAdjacent;
                    }

                    var tempCount = 0;
                    var auxValue = j - 1;

                    if (i - 1 >= 0)
                    {
                        while (tempCount < 3)
                        {
                            if (auxValue < 0 || auxValue > input.Length - 1)
                            {
                                tempCount++;
                                continue;
                            }

                            if (input[i - 1][auxValue] == '@')
                                ++hasAdjacent;
                            auxValue++;
                            tempCount++;
                        }
                    }

                    tempCount = 0;
                    auxValue = j - 1;

                    if (i + 1 < input.Length)
                    {
                        while (tempCount < 3)
                        {
                            if (auxValue < 0 || auxValue > input.Length - 1)
                            {
                                tempCount++;
                                auxValue++;
                                continue;
                            }

                            if (input[i + 1][auxValue] == '@')
                                ++hasAdjacent;
                            auxValue++;
                            tempCount++;
                        }
                    }

                    if (hasAdjacent < 4)
                    {
                        retValue++;
                    }
                }
            }
        }

        return retValue;
    }
}
