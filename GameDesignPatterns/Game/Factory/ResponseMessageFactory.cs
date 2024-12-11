public class ResponseMessageFactory
{
    public ResponseMessage GetResponseMessage(int guess, int correctAnswer)
    {
        if (guess == correctAnswer)
            return new CorrectGuessMessage();
        else if (guess > correctAnswer)
            return new HighGuessMessage();
        else
            return new LowGuessMessage();
    }
}
