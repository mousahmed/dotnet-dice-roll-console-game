int tries = 3;
var game = new DiceRollGame();

while (tries > 0)
{
  Console.WriteLine("Guess the dice number (1-6): ");
  string input = Console.ReadLine();
  int guess;

  if (!int.TryParse(input, out guess) || guess < 1 || guess > 6)
  {
    Console.WriteLine("Incorrect input");
    continue;
  }

  if (game.IsRightGuess(guess))
  {
    Console.WriteLine("You win");
    break;
  }
  else
  {
    Console.WriteLine("Wrong number");
    tries--;
  }

  if (tries == 0 && !game.IsRightGuess(guess))
  {
    Console.WriteLine("You lose");
  }
}



class DiceRollGame
{
  readonly int _dice;
  public DiceRollGame()
  {
    _dice = new Random().Next(1, 6);
  }

  public bool IsRightGuess(int guess)
  {
    return _dice == guess;
  }

}