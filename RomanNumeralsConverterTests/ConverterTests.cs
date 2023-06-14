using RomanNumeralsConverter;

namespace RomanNumeralsConverterTests;

public class ConverterTests
{
    [Test, 
     TestCase(1, "I"),
     TestCase(2, "II"),
     TestCase(3, "III"),
     TestCase(4, "IV"),
     TestCase(5, "V"),
     TestCase(9, "IX"),
     TestCase(10, "X"),
     TestCase(11, "XI"),
     TestCase(14, "XIV"),
     TestCase(15, "XV"),
     TestCase(20, "XX"),
     TestCase(23, "XXIII"),
     TestCase(40, "XL"),
     TestCase(50, "L"),
     TestCase(90, "XC"),
     TestCase(100, "C"),
     TestCase(278, "CCLXXVIII"),
     TestCase(400, "CD"),
     TestCase(500, "D"),
     TestCase(900, "CM"),
     TestCase(999, "CMXCIX"),
     TestCase(1000, "M"),
     TestCase(1378, "MCCCLXXVIII"),
     TestCase(1500, "MD"),
     TestCase(1548, "MDXLVIII"),
     TestCase(1999, "MCMXCIX"),
     TestCase(2000, "MM")]
    public void ShouldCorrectlyConvertDecimalsToRomanNumerals(int input, string expected)
    {
        var actual = Converter.DecimalToRomanNumerals(input);
        Assert.That(actual, Is.EqualTo(expected), $"Failed for {input}, got {actual}, expected {expected}");
    }

    [Test]
    public void ShouldThrowWhenArgumentIsLessThanOne()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Converter.DecimalToRomanNumerals(0), "Should throw for 0");
        Assert.Throws<ArgumentOutOfRangeException>(() => Converter.DecimalToRomanNumerals(-1), "Should throw for -1");
        Assert.Throws<ArgumentOutOfRangeException>(() => Converter.DecimalToRomanNumerals(2001), "Should throw for 2001");
    }
}