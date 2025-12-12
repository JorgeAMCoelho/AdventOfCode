namespace AdventOfCode;

public class Reader
{
    public static string[] ReadInputArrayStrings(string fileName)
    {
        var inputPath = $"C:\\Users\\j.coelho\\source\\repos\\Inputs\\{fileName}";

        var anotherInputPath = $"C:\\Users\\jorge\\source\\repos\\AdventOfCodeInputs\\{fileName}";

        var theLastInputPath = $"D:\\Advent of code 2025 - Inputs\\{fileName}";

        string[] file;

        try
        {
            file = File.ReadAllLines(inputPath);
        }
        catch (Exception e)
        {
            try
            {
                file = File.ReadAllLines(anotherInputPath);
            }
            catch (Exception ex)
            {
                file = File.ReadAllLines(theLastInputPath);
            }
        }

        return file;
    }

    public static string ReadInputStrings(string fileName)
    {
        var inputPath = $"C:\\Users\\j.coelho\\source\\repos\\Inputs\\{fileName}";

        var anotherInputPath = $"C:\\Users\\jorge\\source\\repos\\AdventOfCodeInputs\\{fileName}";

        string file;

        try
        {
            file = File.ReadAllText(inputPath).Trim();
        }
        catch (Exception e)
        {
            file = File.ReadAllText(anotherInputPath).Trim();
        }

        return file;
    }
}
