public class GameObserver : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine(message);
    }
}
