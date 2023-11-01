using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        // Arrange
        int[] lis = null;

        // Act & Arrenge
        Assert.That(() => LongestIncreasingSubsequence.GetLis(lis), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // Arrenge 
        int[] lis = Array.Empty<int>();

        // Act
        string output = LongestIncreasingSubsequence.GetLis(lis);

        // Assert
        Assert.That(output, Is.Empty);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        // Arrenge 
        int[] lis = new int[] {1};

        // Act
        string output = LongestIncreasingSubsequence.GetLis(lis);

        // Assert
        Assert.That(output, Is.EqualTo("1")); 
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        // Arrenge 
        int[] lis = new int[] { 1, 2, 5, 7, 3, 4 };

        // Act
        string output = LongestIncreasingSubsequence.GetLis(lis);

        // Assert
        Assert.That(output, Is.EqualTo("1 2 5 7"));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        // Arrenge 
        int[] lis = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        // Act
        string output = LongestIncreasingSubsequence.GetLis(lis);

        // Assert
        Assert.That(output, Is.EqualTo("1 2 3 4 5 6 7"));
    }
}
