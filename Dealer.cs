//In charge of tracking the most recently used card, the newest card, and how many points the player has
class Dealer {

    //initialize variables
    public int points = 0;
    public string guess = "";
    public int oldCard = 0;

    public Dealer() {
        //starting value for player
        points = 300;
    }

    public int GetPoints(int points) {
        return points;
    }

    //shows the player how many points they have left
    public void DisplayPoints() {
        Console.WriteLine($"You have {points} points.");
    }

        public void PlayCard(int newCard) {
        Console.WriteLine($"The card is: {newCard}");
    }

    //prompts the player to guess High or Low
    public string GetGuess() {
        Console.Write("High or Low [h/l]: ");
        return guess = Console.ReadLine() ?? "";
    }

    public int DisplayNextCard(int newCard) {
        Console.WriteLine($"The next card was: {newCard}");
        //the new card revealed now becomes the old card
        oldCard = newCard;

        return oldCard;
    }

    public int CalculatePoints(int newCard) {
        //if guess is correct, add to points
        if ((guess == "h" || guess == "Hi" || guess == "High") && oldCard >= newCard) {
            points += 100;
        }
        else if ((guess == "l" || guess == "Lo" || guess == "Low") && oldCard <= newCard) {
            points += 100;
        }
        //else, subract points
        else {
            points -= 75;
        }

        return points;
    }

    //validates is the player has 0 or less points to terminate the game
    public bool IsGameOver(int points) {
        if (points <= 0) {
            return true;
        }
        return false;
    }
    //explains the rules to the player
    public void ExplainGame() {
        Console.WriteLine("Hello, player. In the game of HiLo, I, your dealer, and you, the player, will engage in a back and forth.");
        Console.WriteLine("I will play a card and you will guess if the next one is numerically higher or lower. After, I will play the next card.");
        Console.WriteLine("If you were correct, then you get 100 points. If you were wrong, I deduct you 75 points. You only lose once you have reached 0 or less.");
        Console.WriteLine("There is. No. Winning.");
        Console.WriteLine("Let's begin.");
    }

}