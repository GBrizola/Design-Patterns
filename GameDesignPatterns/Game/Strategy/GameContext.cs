public class GameContext
{
    private IDifficultyStrategy _difficultyStrategy;

    public void SetDifficulty(IDifficultyStrategy strategy)
    {
        _difficultyStrategy = strategy;
    }

    public void StartGame()
    {
        _difficultyStrategy.Play();
    }
}
