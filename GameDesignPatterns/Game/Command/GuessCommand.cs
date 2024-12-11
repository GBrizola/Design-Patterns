public class GuessCommand : ICommand
{
    private readonly int _guess;
    private readonly Game _game;
    private readonly GameSubject _subject;

    public GuessCommand(int guess, Game game, GameSubject subject)
    {
        _guess = guess;
        _game = game;
        _subject = subject;
    }

    public void Execute()
    {
        _game.Attempts++;
        if (_guess == _game.NumberToGuess)
        {
            _subject.NotifyObservers("Você acertou!");
        }
        else if (_guess > _game.NumberToGuess)
        {
            _subject.NotifyObservers("Muito alto, tente novamente.");
        }
        else
        {
            _subject.NotifyObservers("Muito baixo, tente novamente.");
        }
    }
}
