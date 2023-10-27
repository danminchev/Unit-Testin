using NUnit.Framework;

namespace TestApp.UnitTests;

public class CalculateTests
{
    [Test]
    public void Test_AdditionWhenParameteresArePositive()
    {
        // Arrange
        Calculate calculator = new();

        // Act
        int actual = calculator.Addition(5, 2);

        // Assert
        Assert.AreEqual(7, actual, "Addition did not work properly.");
    }

    [Test]
    public void Test_AdditionWhenParametersAreNegative()
    {
        //Arrange 
        Calculate calculator = new();

        //act
        int actual = calculator.Addition(-5, -2);

        //Assert
        Assert.AreEqual(-7, actual);
    }

    [Test]
    public void Test_SubtractionWhenParametersArePositive()
    {
       // Arrange
        Calculate calculator = new();
  
        // Act
        int actual = calculator.Subtraction(5, 2);

        // Assert
        Assert.AreEqual(3, actual, "Subtraction did not work properly."); 
    }
}
