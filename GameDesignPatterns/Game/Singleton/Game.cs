public class Game
{
    private static Game _instance;
    public int NumberToGuess { get; private set; }
    public int Attempts { get; set; }

    public static Game Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Game();
            return _instance;
        }
    }

    public void Reset(int min = 1, int max = 100)
    {
        var random = new Random();
        NumberToGuess = random.Next(min, max + 1); // Número aleatório entre min e max
        Attempts = 0;
    }
}
