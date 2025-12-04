namespace AdventOfCode.Day_1;

public static class Day1
{
    private readonly static string[] fileInput = Reader.ReadInputArrayStrings("Day1Input.txt");

    private readonly static string[] localInput = ["L68", "L30", "R48", "L5", "R60", "L55", "L1", "L99", "R14", "L82"];

    private readonly static string[] input = localInput;

    public static int DoorPassword()
    {
        var dialPoint = 50;

        var retCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            var direction = input[i][0];

            var distance = int.Parse(input[i][1..]) % 100;

            if (direction == 'L')
            {
                if (dialPoint - distance < 0)
                {
                    dialPoint = 100 - Math.Abs(dialPoint - distance);
                }
                else
                {
                    dialPoint -= distance;
                }
            }
            else if (direction == 'R')
            {
                if (dialPoint + distance > 99)
                {
                    dialPoint = dialPoint + distance - 100;
                }
                else
                {
                    dialPoint += distance;
                }
            }

            if (dialPoint == 0)
            {
                ++retCount;
            }
        }

        return retCount;
    }

    public static int DoorPassword0x434C49434B()
    {
        var dialPoint = 50;

        var retCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            var direction = input[i][0];

            var distance = int.Parse(input[i][1..]) % 100;

            var timesZero = int.Parse(input[i][1..]) / 100;

            if (direction == 'L')
            {
                if (dialPoint - distance < 0)
                {
                    dialPoint = 100 - Math.Abs(dialPoint - distance);
                    retCount = ++retCount + timesZero;
                    continue;
                }
                else
                {
                    dialPoint -= distance;
                }
            }
            else if (direction == 'R')
            {
                if (dialPoint + distance > 99)
                {
                    dialPoint = dialPoint + distance - 100;
                    retCount = ++retCount + timesZero;
                    continue;
                }
                else
                {
                    dialPoint += distance;
                }
            }

            if (dialPoint == 0)
            {
                ++retCount;
            }
        }

        return retCount;
    }
}
