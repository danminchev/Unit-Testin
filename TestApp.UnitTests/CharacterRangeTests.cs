using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        // Arrange
        char a = 'b';
        char b = 'a';

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.AreEqual("", result);
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        // Arrange
        char a = 'b';
        char b = 'a';

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.AreEqual("", result);
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        // Arrange
        char a = 'a';
        char b = 'c';

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.AreEqual("b", result);
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        // Arrange
        char a = 'd';
        char b = 'g';

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.AreEqual("e f", result);
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        // Arrange
        char a = 'x';
        char b = 'z';

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.AreEqual("y", result);
    }
}
