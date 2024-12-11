public class Game
{
    private static Game _instance;
    public int NumberToGuess { get; private set; }
    public int Attempts { get; set; }

    private Game()
    {
        Reset();
    }

    public static Game Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Game();
            return _instance;
        }
    }

    public void Reset()
    {
        var random = new Random();
        NumberToGuess = random.Next(1, 101); // Número aleatório entre 1 e 100
        Attempts = 0;
    }
}
