using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{

    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] input = new char[] { 'H', 'e', '1', 'l', '2', 'l','o' };

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        CollectionAssert.AreEqual(result, new char[] { 'H', 'e', 'l', 'l', 'o' });
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] input = new char[] { 'H', 'e', 'l', 'l', 'o' };

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        CollectionAssert.AreEqual(result, input);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = Array.Empty<char>();

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
