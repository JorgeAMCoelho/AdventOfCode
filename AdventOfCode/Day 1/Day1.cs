using System.Net.NetworkInformation;

namespace AdventOfCode.Day_1;

public class Day1
{
    private readonly static string[] fileInput = Reader.ReadInput("Day1Input.txt");

    private readonly static string[] localInput = ["L68", "L30", "R48", "L5", "R60", "L55", "L1", "L99", "R14", "L82"];

    private static int dialPoint = 50;

    private static int retCount = 0;

    private readonly static string[] input = fileInput;

    public static int DoorPassword()
    {
        for (int i = 0; i < input.Length; i++)
        {
            var direction = input[i][0];

            var distance = int.Parse(input[i][1..]) % 100;

            //var distance = int.Parse(input[i].Substring(Math.Max(0, input[i].Length - 2)));

            if (direction == 'L')
            {
                if(dialPoint - distance < 0)
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
                if(dialPoint + distance > 99)
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
}
