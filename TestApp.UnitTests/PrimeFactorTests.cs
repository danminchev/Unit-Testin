using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        // Arrange
        long n = 1;

        // Act & Assert
        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(n), Throws.ArgumentException);   
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        // Arrange
        long n = 2;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(n);

        // Assert
        Assert.That(result, Is.EqualTo(n)); 
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long n = 987654321;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(n);

        // Assert
        Assert.That(result, Is.EqualTo(379721));
    }
}
