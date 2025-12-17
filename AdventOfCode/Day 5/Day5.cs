namespace AdventOfCode.Day_5;

public static class Day5
{
    private readonly static string[] fileInput = Reader.ReadInputArrayStrings("Day5Input.txt");

    private readonly static string[] localInput = ["3-5", "10-14", "16-20", "12-18",  "", "1", "5", "8", "11", "17", "32"];

    private readonly static string[] input = fileInput;

    public static long AvailableProducts()
    {
        var retValue = 0l;

        var count = 0;

        var ingredientRanges = new List<string>();

        while (!string.IsNullOrWhiteSpace(input[count]))
        {
            ingredientRanges.Add(input[count]);
            ++count;
        }

        for (var i = count + 1; i < input.Length; i++)
        {
            for (var j = 0; j < ingredientRanges.Count; j++)
            {
                var separated = ingredientRanges[j].Split('-');

                if (long.Parse(input[i]) >= long.Parse(separated[0]) && long.Parse(input[i]) <= long.Parse(separated[1]))
                {
                    ++retValue;
                    break;
                }
            }
        }

        return retValue;
    }

    //resposta 365804144481581 - tem bug
    public static long ListAvailableProducts()
    {
        var retValue = 0L;

        var count = 0L;

        var ingredientRanges = new List<string>();

        while (!string.IsNullOrWhiteSpace(input[count]))
        {
            ingredientRanges.Add(input[count]);
            ++count;
        }

        var minValueToCkeck = 0L;
        var maxValueToCheck = 0L;

        var countList = ingredientRanges.GetRange(0, 1).ToList();

        ingredientRanges.RemoveAt(0);

        for (var i = 0 ; i < ingredientRanges.Count;)
        {
            var separated = ingredientRanges[i].Split('-');

            minValueToCkeck = long.Parse(separated[0]);
            maxValueToCheck = long.Parse(separated[1]);

            var toAdd = true;

            for (var j = 0; j < countList.Count; j++)
            {
                var separatedList = countList[j].Split('-');

                var minValueList = long.Parse(separatedList[0]);
                var maxValueList = long.Parse(separatedList[1]);

                toAdd = true;

                if (minValueToCkeck >= minValueList && maxValueToCheck <= maxValueList)
                {
                    toAdd = false;
                    break;
                }

                if (minValueToCkeck >= minValueList && minValueToCkeck <= maxValueList)
                {
                    countList[j] = $"{minValueList}-{maxValueToCheck}";
                    ingredientRanges.AddRange(countList.Skip(j + 1).ToList());
                    countList = countList.Take(j + 1).ToList();
                    toAdd = false;
                    break;
                }

                if (maxValueToCheck <= maxValueList && maxValueToCheck >= minValueList)
                {
                    countList[j] = $"{minValueToCkeck}-{maxValueList}";
                    ingredientRanges.AddRange(countList.Skip(j + 1).ToList());
                    countList = countList.Take(j + 1).ToList();
                    toAdd = false;
                    break;
                }
            }

            if (toAdd)
            {
                countList.Add(ingredientRanges[i]);
            }

            ingredientRanges.RemoveAt(i);
        }

        foreach (var countL in countList)
        {
            var sep = countL.Split('-');

            var min = long.Parse(sep[0]);
            var max = long.Parse(sep[1]);

            retValue += max - min + 1;
        }

        return retValue;
    }
}
