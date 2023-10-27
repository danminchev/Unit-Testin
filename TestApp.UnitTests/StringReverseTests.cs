using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
   
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
         Assert.AreEqual(string.Empty, actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "X";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(1, input.Length);
        Assert.AreEqual("X", actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "XYZ";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(input.Length, actual.Length);
        Assert.AreEqual("ZYX", actual);
    }
}
