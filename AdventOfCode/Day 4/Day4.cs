namespace AdventOfCode.Day_4;

public static class Day4
{
    private readonly static string[] fileInput = Reader.ReadInputArrayStrings("Day4Input.txt");

    private readonly static string[] localInput = ["..@@.@@@@.", "@@@.@.@.@@", "@@@@@.@.@@", "@.@@@@..@.", "@@.@@@@.@@", ".@@@@@@@.@", ".@.@.@.@@@", "@.@@@.@@@@", ".@@@@@@@@.", "@.@.@@@.@."];

    private readonly static string[] input = fileInput;

    public static int AccessByForklift()
    {
        var retValue = 0;

        var grid = input.Select(row => row.ToCharArray()).ToArray();

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid.Length; j++)
            {
                var hasAdjacent = 0;

                if (grid[i][j] == '@')
                {
                    if (j - 1 >= 0)
                    {
                        if (grid[i][j - 1] == '@')
                            ++hasAdjacent;
                    }

                    if (j + 1 < input.Length)
                    {
                        if (grid[i][j + 1] == '@')
                            ++hasAdjacent;
                    }

                    var tempCount = 0;
                    var auxValue = j - 1;

                    if (i - 1 >= 0)
                    {
                        while (tempCount < 3)
                        {
                            if (auxValue < 0 || auxValue > grid.Length - 1)
                            {
                                auxValue++;
                                tempCount++;
                                continue;
                            }

                            if (grid[i - 1][auxValue] == '@')
                                ++hasAdjacent;
                            auxValue++;
                            tempCount++;
                        }
                    }

                    tempCount = 0;
                    auxValue = j - 1;

                    if (i + 1 < grid.Length)
                    {
                        while (tempCount < 3)
                        {
                            if (auxValue < 0 || auxValue > grid.Length - 1)
                            {
                                tempCount++;
                                auxValue++;
                                continue;
                            }

                            if (grid[i + 1][auxValue] == '@')
                                ++hasAdjacent;
                            auxValue++;
                            tempCount++;
                        }
                    }

                    if (hasAdjacent < 4)
                    {
                        //grid[i][j] = 'X';
                        retValue++;
                    }
                }
            }
        }

        return retValue;
    }

    public static int RemoveByForklift()
    {
        var retValue = 0;

        var grid = input.Select(row => row.ToCharArray()).ToArray();

        while (true)
        {
            var breakCond = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid.Length; j++)
                {
                    var hasAdjacent = 0;

                    if (grid[i][j] == '@')
                    {
                        if (j - 1 >= 0)
                        {
                            if (grid[i][j - 1] == '@')
                                ++hasAdjacent;
                        }

                        if (j + 1 < input.Length)
                        {
                            if (grid[i][j + 1] == '@')
                                ++hasAdjacent;
                        }

                        var tempCount = 0;
                        var auxValue = j - 1;

                        if (i - 1 >= 0)
                        {
                            while (tempCount < 3)
                            {
                                if (auxValue < 0 || auxValue > grid.Length - 1)
                                {
                                    auxValue++;
                                    tempCount++;
                                    continue;
                                }

                                if (grid[i - 1][auxValue] == '@')
                                    ++hasAdjacent;
                                auxValue++;
                                tempCount++;
                            }
                        }

                        tempCount = 0;
                        auxValue = j - 1;

                        if (i + 1 < grid.Length)
                        {
                            while (tempCount < 3)
                            {
                                if (auxValue < 0 || auxValue > grid.Length - 1)
                                {
                                    tempCount++;
                                    auxValue++;
                                    continue;
                                }

                                if (grid[i + 1][auxValue] == '@')
                                    ++hasAdjacent;
                                auxValue++;
                                tempCount++;
                            }
                        }

                        if (hasAdjacent < 4)
                        {
                            grid[i][j] = '.';
                            retValue++;
                            breakCond = retValue;
                        }
                    }
                }
            }

            if (breakCond == 0)
            {
                break;
            }
        }

        return retValue;
    }
}
