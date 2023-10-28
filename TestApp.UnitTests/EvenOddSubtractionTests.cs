using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange 
        int[] evenArray = new int[2] { 10, 10 };

        // Act
        int result = EvenOddSubtraction.FindDifference(evenArray);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] oddArray = new int[3] { 3, 7, 7 };

        // Act
        int result = EvenOddSubtraction.FindDifference(oddArray);

        // Assert
        Assert.That(result, Is.EqualTo(17));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] mixedArray = new int[5] { 1, 4, 7, 10, 11 };

        // Act
        int result = EvenOddSubtraction.FindDifference(mixedArray);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
}
