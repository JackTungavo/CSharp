public class Game
{
    private int secretNumber;

    // Constructor to initialize the game with a secret number
    public Game(int secretNumber)
    {
        this.secretNumber = secretNumber;
    }

    // Method for players to make a guess and receive feedback
    public string Guess(int playerGuess)
    {
        if (playerGuess < secretNumber)
        {
            return "higher";
        }
        else if (playerGuess > secretNumber)
        {
            return "lower";
        }
        else
        {
            return "correct-a-reno!!";
        }
    }
}

class Program
{
    static void Main()
    {
        // Player One creates a new game with a secret number
        Game game = new Game(10);

        // Player Two makes guesses and receives feedback
        Console.WriteLine(game.Guess(5));  // => "higher"
        Console.WriteLine(game.Guess(20)); // => "lower"
        Console.WriteLine(game.Guess(10)); // => "correct-a-reno!!"
    }
}