using AdventOfCode.Day_1;
using AdventOfCode.Day_2;
using AdventOfCode.Day_3;

namespace AdventOfCode;

internal class Program
{
    static void Main(string[] args)
    {
        var doorPassword = Day1.DoorPassword();
        var doorPassword0x434C49434B = Day1.DoorPassword0x434C49434B();

        Console.WriteLine("----------------------DAY1--------------------");
        Console.WriteLine("The doorPassword is: " + doorPassword);
        Console.WriteLine("The doorPassword0x434C49434B is: " + doorPassword0x434C49434B);
        Console.WriteLine();

        Console.WriteLine("----------------------DAY2--------------------");
        var invalidIdsSum = Day2.InvalidIds();
        var invalidIdsSumPartTwo = Day2.InvalidIdsPartTwo();
        Console.WriteLine("Invalid Ids sum: " + invalidIdsSum);
        Console.WriteLine("Invalid Ids sum part two: " + invalidIdsSumPartTwo);
        Console.WriteLine();

        Console.WriteLine("----------------------DAY3--------------------");
        var maximumJoltage = Day3.MaximumJoltage();
        var maximumJoltage12Bateries = Day3.MaximumJoltage12Bateries();
        Console.WriteLine("Sum of Maximum Joltage: " + maximumJoltage);
        Console.WriteLine("Sum of Maximum Joltage 12 Bateries: " + maximumJoltage12Bateries);
        Console.WriteLine();

        Console.ReadLine();
        return;
    }
}
