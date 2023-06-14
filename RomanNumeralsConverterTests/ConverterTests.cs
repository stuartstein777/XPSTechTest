using RomanNumeralsConverter;

namespace RomanNumeralsConverterTests;

public class Tests
{
    [Test]
    public void ShouldCorrectlyConvertDecimalsToRomanNumerals()
    {
        var expectedResults = new List<(int, string)>
        {
            (1, "I"),
            (2, "II"),
            (3, "III"),
            (4, "IV"),
            (5, "V"),
            (9, "IX"),
            (10, "X"),
            (11, "XI"),
            (14, "XIV"),
            (15, "XV"),
            (20, "XX"),
            (23, "XXIII"),
            (40, "XL"),
            (50, "L"),
            (90, "XC"),
            (100, "C"),
            (278, "CCLXXVIII"),
            (400, "CD"),
            (500, "D"),
            (900, "CM"),
            (999, "CMXCIX"),
            (1000, "M"),
            (1378, "MCCCLXXVIII"),
            (1500, "MD"),
            (1548, "MDXLVIII"),
            (1999, "MCMXCIX"),
            (2000, "MM")
        };

        foreach(var (test, expected) in expectedResults)
        {
            var actual = Converter.DecimalToRomanNumerals(test);
            Assert.That(actual, Is.EqualTo(expected), $"Failed for {test}, got {actual}, expected {expected}");
        }
    }

    [Test]
    public void ShouldThrowWhenArgumentIsLessThanOne()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Converter.DecimalToRomanNumerals(0), "Should throw for 0");
        Assert.Throws<ArgumentOutOfRangeException>(() => Converter.DecimalToRomanNumerals(-1), "Should throw for -1");
        Assert.Throws<ArgumentOutOfRangeException>(() => Converter.DecimalToRomanNumerals(2001), "Should throw for 2001");
    }
}