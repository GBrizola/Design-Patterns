using Xunit;
using System;

public class GameContextTest
{
    [Fact]
    public void GameContext_ShouldUseEasyDifficulty()
    {
        // Arrange
        var context = new GameContext();
        var easyStrategy = new EasyDifficulty();
        context.SetDifficulty(easyStrategy);

        // Act
        using (var sw = new System.IO.StringWriter())
        {
            Console.SetOut(sw);
            context.StartGame();

            // Assert
            var result = sw.ToString().Trim();
            Assert.Equal("Modo Fácil: O número está entre 1 e 50.", result);
        }
    }
}
