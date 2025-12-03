namespace AdventOfCode;

public class Reader
{
    public static string[] ReadInput(string fileName)
    {
        var inputPath = $"C:\\Users\\j.coelho\\source\\repos\\AdventOfCode\\Inputs\\{fileName}";

        return File.ReadAllLines(inputPath);
    }
}
