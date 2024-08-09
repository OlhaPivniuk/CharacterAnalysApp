using CharacterAnalysApp;

namespace CharacterAnalysAppTests;

public class StringAnalyzerTests
{
    private readonly StringAnalyzer _analyzer = new StringAnalyzer();

    [Theory]
    [InlineData("", 0)] 
    [InlineData("a", 1)] 
    [InlineData("aaaaa", 1)] 
    [InlineData("abababab", 8)] 
    [InlineData("aabbcbcc", 4)]
    [InlineData("aabbccddeeff", 2)]
    public void MaxUnequalConsecutiveChars_VariousInputs_ReturnsCorrectMaxLength(string input, int expected)
    {
        // Act
        int result = _analyzer.MaxNumberUnequalConsecutiveChar(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("", 0)] 
    [InlineData("a", 1)] 
    [InlineData("aaaaa", 5)] 
    [InlineData("aabbcc", 2)] 
    [InlineData("aabbbcc", 3)] 
    [InlineData("a1b2c3d4", 1)] 
    [InlineData("aabbccdd", 2)] 
    [InlineData("a1bb2cc3dd", 2)] 
    [InlineData("abcddcb", 2)] 
    [InlineData("abcddeeeeefggh", 5)]
    [InlineData("aAaAaA", 1)] 
    [InlineData("a" + "b" + "c" + "d" + "e" + "f", 1)] 
    public void MaxNumberConsecutiveIdenticalLetters_VariousInputs_ReturnsCorrectMaxLength(string input, int expected)
    {
        // Act
        int result = _analyzer.MaxNumberConsecutiveIdenticalLetters(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("", 0)] 
    [InlineData("1", 1)] 
    [InlineData("11111", 5)] 
    [InlineData("123456", 1)] 
    [InlineData("1223334444", 4)] 
    [InlineData("1a2b3c4d5e", 1)] 
    [InlineData("111222333", 3)] 
    [InlineData("9a8b777777", 6)] 
    [InlineData("123123123123", 1)] 
    [InlineData("000111100011110000", 4)]
    [InlineData("1 2 3 4 5", 1)] 
    public void MaxNumberConsecutiveIdenticalDigits_VariousInputs_ReturnsCorrectMaxLength(string input, int expected)
    {
        // Act
        int result = _analyzer.MaxNumberConsecutiveIdenticalDigits(input);

        // Assert
        Assert.Equal(expected, result);
    }

}