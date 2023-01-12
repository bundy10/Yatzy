using Moq;
using Yatzy_Kata;
using Yatzy_Kata.Interfaces;

namespace Yatzy_Test;

public class GameTests
{
    [Fact]
    public void GivenPlayGameIsCalled_ThenPromptsPlayerToPlayAgain()
    {
        //Arrange
        var playerMock = new Mock<IPlayer>();
        var game = new Game(new[] { playerMock.Object});
        playerMock.Setup(player => player.PlayAgain()).Verifiable();
        
        //Act
        game.PlayGame();
        
        //Assert
        playerMock.Verify();
    }
}