using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {   // Arrange
        decimal money = 100;
        List<int> initialQuality = new List<int>() { 3, 4 };
        List<string> commands = new List<string>() { "1", "1" };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, initialQuality, commands));
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {   // Arrange
        decimal money = 100;
        List<int> initialQuality = new List<int>() { 3, 4 };
        List<string> commands = new List<string>() { "1", "1", "string" };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, initialQuality, commands));
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal money = 100;
        List<int> initialQuality = new List<int>() { 3, 4, };
        List<string> commands = new() { "1", "1", "Hit it again, Gabsy!" };

        string expected = "1 2\nGabsy has 100.00lv.";

        // Act
        string output = DrumSet.Drum(money, initialQuality, commands);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal money = 0;
        List<int> initialQuality = new List<int>() { 1, 2 };
        List<string> commands = new List<string>() { "1", "1", "2", "Hit it again, Gabsy!" };

        string expected = "\nGabsy has 0.00lv.";

        // Act
        string output = DrumSet.Drum(money, initialQuality, commands);

        //Assert
        Assert.That(expected, Is.EqualTo(output));
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal money = 9;
        List<int> initialQuality = new List<int>() { 3, 3 };
        List<string> commands = new List<string>() { "1", "1", "2", "Hit it again, Gabsy!" };

        string expected = "\nGabsy has 9.00lv.";
        // Act
        string output = DrumSet.Drum(money, initialQuality, commands);

        //Assert
        Assert.That(expected, Is.EqualTo(output));
    }

    [Test]
    public void Test_Drum_BrokenDrum_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal money = 100;
        List<int> initialQuality = new List<int>() { 3, 10 };
        List<string> commands = new List<string>() { "2", "2", "Hit it again, Gabsy!" };

        string expected = "3 6\nGabsy has 91.00lv.";

        // Act
        string output = DrumSet.Drum(money, initialQuality, commands);

        //Assert
        Assert.That(expected, Is.EqualTo(output));
    }
}
