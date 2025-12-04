namespace AdventOfCode;

public class Reader
{
    public static string[] ReadInputArrayStrings(string fileName)
    {
        var inputPath = $"C:\\Users\\j.coelho\\source\\repos\\Inputs\\{fileName}";

        var anotherInputPath = $"C:\\Users\\jorge\\source\\repos\\AdventOfCodeInputs\\{fileName}";

        string[] file;

        try
        {
            file = File.ReadAllLines(inputPath);
        }
        catch (Exception e)
        {
            file = File.ReadAllLines(anotherInputPath);
        }

        return file;
    }
}
