using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public class DrawAsNumber : Attribute
{
    
}

public static class StringToNumber
{
    private static Dictionary<string, int> stringToNumber = new Dictionary<string, int>()
    {
        {"two", 2},
        {"three", 3},
    };

    public static string ToNumber(string numberString)
    {
        var numbersFound = stringToNumber
            .Where(pair => numberString
                .ToLower()
                .Contains(pair.Key))
            .ToDictionary(pair => pair.Key, pair => pair.Value);

        return numbersFound.Aggregate(numberString,
            (current, pair) => Regex.Replace(current, pair.Key, pair.Value.ToString(), RegexOptions.IgnoreCase));
    }
}