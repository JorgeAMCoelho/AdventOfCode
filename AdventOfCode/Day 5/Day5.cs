using System.Numerics;

namespace AdventOfCode.Day_5;

public static class Day5
{
    private readonly static string[] fileInput = Reader.ReadInputArrayStrings("Day5Input.txt");

    private readonly static string[] localInput = ["3-5", "10-14", "16-20", "12-18", "", "1", "5", "8", "11", "17", "32"];

    private readonly static string[] input = localInput;

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

        var minValue = 0L;
        var maxValue = 0L;

        var countList = ingredientRanges.GetRange(0, 1).ToList();

        for (var i = 1; i < ingredientRanges.Count; i++)
        {
            var separated = ingredientRanges[i].Split('-');

            minValue = long.Parse(separated[0]);
            maxValue = long.Parse(separated[1]);

            for(var j = 0; j < countList.Count; j++)
            {
                var separatedList = countList[j].Split('-');

                var minValueList = long.Parse(separatedList[0]);
                var maxValueList = long.Parse(separatedList[1]);

                if (minValue >= minValueList && minValue >= maxValueList || maxValue <= maxValueList && maxValue <= minValueList)
                {
                    countList.Add(countList[j]);
                }

                if(minValue > minValueList && maxValue > maxValueList)
                {
                    countList[j] = $"{minValueList}-{maxValue}";
                }
            }



            //for(var j = long.Parse(separated[0]); j <= long.Parse(separated[1]); j++)
            //{
            //    if (!finalList.Any(x => x == initialValue))
            //    {
            //        finalList.Add(initialValue);
            //    }
            //    ++initialValue;
            //}
        }

        return countList.Count;
    }
}
