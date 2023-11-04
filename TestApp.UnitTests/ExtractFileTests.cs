using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(path));
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = string.Empty;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(path));
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = @"C:\folder\file.txt";

        string expected = "File name: file\nFile extension: txt";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange
        string path = @"D:\another_folder\document";

        string expected = "File name: document";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = @"E:\data\my_file 123.docx";

        string expected = "File name: my_file 123\nFile extension: docx";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
