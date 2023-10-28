using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{

    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => AdjacentEqual.Sum(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> equalList = new List<int>() { 1, 2, 3, 4, 3, 5 };

        // Act
        string result = AdjacentEqual.Sum(equalList);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 3 5"));
        
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arange 
        List<int> list = new List<int>() { 1, 2, 3, 3, 5 };

        // Act
        string result = AdjacentEqual.Sum(list);

        //Assert
        Assert.That(result, Is.EqualTo("1 2 6 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arange 
        List<int> list = new List<int>() { 2, 2, 4, 8, 16 };

        // Act
        string result = AdjacentEqual.Sum(list);

        //Assert
        Assert.That(result, Is.EqualTo("32"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arange 
        List<int> list = new List<int>() { 2, 2, 7, 8 };

        // Act
        string result = AdjacentEqual.Sum(list);

        //Assert
        Assert.That(result, Is.EqualTo("4 7 8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange 
        List<int> list = new List<int>() { 2, 3, 7, 7 };

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("2 3 14"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arange 
        List<int> list = new List<int>() { 2, 3, 4, 4, 5, 6 };

        // Act
        string result = AdjacentEqual.Sum(list);

        // Assert
        Assert.That(result, Is.EqualTo("2 3 8 5 6"));
    }
}
