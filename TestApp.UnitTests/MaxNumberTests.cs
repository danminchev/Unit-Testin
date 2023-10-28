using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange 
        List<int> list = new List<int>() { 42 };

        // Arrange 
        int result = MaxNumber.FindMax(list);

        // Assert 
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange 
        List<int> positiveList = new List<int>() { 1, 3, 5, 7, 42 };

        // Act
        int result = MaxNumber.FindMax(positiveList);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> negativeList = new List<int>() { -1, -3, -5, -7, -42 };

        // Act
        int result = MaxNumber.FindMax(negativeList);

        // Assert
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> mixedList = new List<int>() { -1, -3, 5, 7, 100 };

        // Act
        int result = MaxNumber.FindMax(mixedList);

        // Assert
        Assert.That(result, Is.EqualTo(100));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> mixedList = new List<int>() { 100, 7, -1, -3, 5, 7, 100 };

        // Act
        int result = MaxNumber.FindMax(mixedList);

        // Assert
        Assert.That(result, Is.EqualTo(100));

    }
}



