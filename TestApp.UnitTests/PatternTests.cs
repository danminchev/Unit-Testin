using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? inputArray = null;

        // Act + Assert
        Assert.That(() => Pattern.SortInPattern(inputArray), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] inputArray = new int[] { 1, 3, 4, 5, 7, 11, 12, 13, 14, };

        // Act
        int[] result = Pattern.SortInPattern(inputArray);

        // Assert
        CollectionAssert.AreEqual(result, (new int[] { 1, 14, 3, 13, 4, 12, 5, 11, 7 }));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] inputArray = Array.Empty<int>();

        // Act
        int[] result = Pattern.SortInPattern(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] inputArray = new int[] { 7 };

        // Act
        int[] result = Pattern.SortInPattern(inputArray);

        // Assert
        CollectionAssert.AreEqual(result, inputArray);
    }
}
