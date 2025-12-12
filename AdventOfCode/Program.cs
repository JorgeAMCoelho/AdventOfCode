using AdventOfCode.Day_3;
using AdventOfCode.Day_4;
using AdventOfCode.Day_5;

namespace AdventOfCode;

internal class Program
{
    static void Main(string[] args)
    {
        //var doorPassword = Day1.DoorPassword();
        //var doorPassword0x434C49434B = Day1.DoorPassword0x434C49434B();

        //Console.WriteLine("----------------------DAY1--------------------");
        //Console.WriteLine("The doorPassword is: " + doorPassword);
        //Console.WriteLine("The doorPassword0x434C49434B is: " + doorPassword0x434C49434B);
        //Console.WriteLine();

        //Console.WriteLine("----------------------DAY2--------------------");
        //var invalidIdsSum = Day2.InvalidIds();
        //var invalidIdsSumPartTwo = Day2.InvalidIdsPartTwo();
        //Console.WriteLine("Invalid Ids sum: " + invalidIdsSum);
        //Console.WriteLine("Invalid Ids sum part two: " + invalidIdsSumPartTwo);
        //Console.WriteLine();

        //Console.WriteLine("----------------------DAY3--------------------");
        //var maximumJoltage = Day3.MaximumJoltage();
        //var maximumJoltage12Bateries = Day3.MaximumJoltage12Bateries();
        //Console.WriteLine("Sum of Maximum Joltage: " + maximumJoltage);
        //Console.WriteLine("Sum of Maximum Joltage 12 bateries: " + maximumJoltage12Bateries);
        //Console.WriteLine();

        //Console.WriteLine("----------------------DAY4--------------------");
        //var accessByForklift = Day4.AccessByForklift();
        //var removeByForklift = Day4.RemoveByForklift();
        //Console.WriteLine("Number of rolls accessed by forklift: " + accessByForklift);
        //Console.WriteLine("Number of rolls removed by forklift: " + removeByForklift);
        //Console.WriteLine();

        Console.WriteLine("----------------------DAY5--------------------");
        var availableProducts = Day5.AvailableProducts();
        var listAvailableProducts = Day5.ListAvailableProducts();
        Console.WriteLine("Number of available products: " + availableProducts);
        Console.WriteLine("Number of list available products: " + listAvailableProducts);
        Console.WriteLine();

        Console.ReadLine();
        return;
    }
}
