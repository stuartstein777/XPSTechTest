﻿using System.Text;

namespace RomanNumeralsConverter;

public static class Converter
{
    /// <summary>
    /// Converts a number between 1 and 2000 (inclusive) to Roman Numerals.
    /// </summary>
    /// <param name="n">The value to convert to Roman Numerals.</param>
    /// <returns>Roman Numerals as String.</returns>
    /// <exception cref="ArgumentOutOfRangeException">Throws if n less than 1 or n greater than 2000.</exception>
    public static string DecimalToRomanNumerals(int n)
    {
        if (n is < 1 or > 2000)
            throw new ArgumentOutOfRangeException(nameof(n), "n must be between 1 and 2000 inclusive");

        var conversions = new List<(int, string)>
        {
            (1000, "M"),
            (900, "CM"),
            (500, "D"),
            (400, "CD"),
            (100, "C"),
            (90, "XC"),
            (50, "L"),
            (40, "XL"),
            (10, "X"),
            (9, "IX"),
            (5, "V"),
            (4, "IV"),
            (1, "I")
        };

        var result = new StringBuilder();

        foreach (var (dec, romanNumeral) in conversions)
        {
            var q = n / dec;
            for(var i = 0; i < q; i++)
                result.Append(romanNumeral);
            n -= dec * q;
        }
        
        return result.ToString();
    }
}