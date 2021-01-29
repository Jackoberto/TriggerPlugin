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
        {"zero", 0},
        {"one", 1},
        {"two", 2},
        {"three", 3},
        {"four", 4},
        {"five", 5},
        {"six", 6},
        {"seven", 7},
        {"eight", 8},
        {"nine", 9},
        {"ten", 10},
        {"eleven", 11},
        {"twelve", 12},
        {"thirteen", 13},
        {"fourteen", 14},
        {"fifteen", 15},
        {"sixteen", 16},
        {"seventeen", 17},
        {"eighteen", 18},
        {"nineteen", 19},
        {"twenty", 20},
        {"thirty", 30},
        {"forty", 40},
        {"fifty", 50},
        {"sixty", 60},
        {"seventy", 70},
        {"eighty", 80},
        {"ninety", 90}
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