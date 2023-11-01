using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class PascalTriangleTests
{
    [TestCase(1, "1 \n")]
    [TestCase(0, "")]
    [TestCase(-1, "")]
    [TestCase(3, "1 \n1 1 \n1 2 1 \n")]
    [TestCase(5, "1 \n1 1 \n1 2 1 \n1 3 3 1 \n1 4 6 4 1 \n")]
    public void Test_PrintTriangle_ShouldReturnCorrectString(int n, string expected)
    {
        // Act
        string output = PascalTriangle.PrintTriangle(n);

        // Assert
        Assert.AreEqual(expected, output);
    }
}
