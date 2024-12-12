public class Program
{
    static void Main(string[] args)
    {
        var game = Game.Instance;
        var gameSubject = new GameSubject();
        var observer = new GameObserver();
        gameSubject.AddObserver(observer);

        var gameContext = new GameContext();
        Console.WriteLine("Escolha o nível de dificuldade \n1 - Fácil \n2 - Difícil");
        string difficulty = Console.ReadLine();

        if (difficulty == "1")
        {
            gameContext.SetDifficulty(new EasyDifficulty());
            game.Reset(1, 50);
        }

        if (difficulty == "2")
        {
          gameContext.SetDifficulty(new HardDifficulty());
            game.Reset(1, 100);
        }

        gameContext.StartGame();
        
        int guess;
        do
        {
            Console.WriteLine("Adivinhe o número:");
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                var command = new GuessCommand(guess, game, gameSubject);
                command.Execute();
            } else {
                Console.WriteLine("Por favor, digite um número válido.");
            }
        } while (game.Attempts < 10 && guess != game.NumberToGuess);

        if (guess == game.NumberToGuess)
        {
            Console.WriteLine("Parabéns! Você adivinhou o número.");
        }
        else
        {
            Console.WriteLine("Você não conseguiu adivinhar o número. Fim de jogo.");
        }
    }
}
