using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        //Arenge
        int input = 0;

        //Act
        string result = Triangle.PrintTriangle(input);

        //Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        //Arrange
        int input = 3;

        string expectedOutput = "1" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1";

        //Act
        string result = Triangle.PrintTriangle(input);

        //Asert
        Assert.AreEqual(expectedOutput, result);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        int input = 5;

        string expectedOutput = "1" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3 4 5" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1";

        //Act
        string result = Triangle.PrintTriangle(input);

        //Asert
        Assert.AreEqual(expectedOutput, result);
    }
}
