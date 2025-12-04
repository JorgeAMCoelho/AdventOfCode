using AdventOfCode.Day_1;

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
        Console.WriteLine();

        Console.ReadLine();
        return;
    }
}
