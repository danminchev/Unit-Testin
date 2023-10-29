using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string email = "test.example.com";

        // Act
        bool result = Email.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string? email = null;

        // Act
        bool result = Email.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.False);
    }
}
