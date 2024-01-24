namespace NumberGuesser.Tests;

public class GameTests
{
    [Test]
    public void Guess_TooLow_ReturnsHigher()
    {
        // Arrange
        Game game = new Game(10);

        // Act
        string result = game.Guess(5);

        // Assert
        Assert.Equal("higher", result);
    }

    [Test]
    public void Guess_TooHigh_ReturnsLower()
    {
        // Arrange
        Game game = new Game(10);

        // Act
        string result = game.Guess(20);

        // Assert
        Assert.Equal("lower", result);
    }

    [Test]
    public void Guess_Correct_ReturnsCorrect()
    {
        // Arrange
        Game game = new Game(10);

        // Act
        string result = game.Guess(10);

        // Assert
        Assert.Equal("correct-a-reno!!", result);
    }
}