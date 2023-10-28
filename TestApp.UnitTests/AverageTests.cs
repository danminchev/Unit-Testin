using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{

    [Test]
    public void Test_CalculateAverage_InputIsEmptyArray_ShouldThrowArgumentException()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act & Assert
        Assert.That(() => Average.CalculateAverage(emptyArray), Throws.ArgumentException);
       
    }

    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 42 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] positiveArray = new int[3] { 2, 3, 4 };

        // Act
        double result = Average.CalculateAverage(positiveArray);

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] negativeArray = new int[2] { -20, -40};

        // Act
        double result = Average.CalculateAverage(negativeArray);

        // Assert
        Assert.That(result, Is.EqualTo(-30));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] mixedArray = new int[5] { -1, -3, 5, 7, 9 };

        // Act
        double result = Average.CalculateAverage(mixedArray);

        // Assert
        Assert.That(result, Is.EqualTo(3.4));
    }
}
