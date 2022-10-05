//In charge of running the game
class Hilo {

static void Main(string[] args) {

    //variables    
    Dealer dealer = new Dealer();
    Deck deck = new Deck();
    
    //introduce the game to the player
    dealer.ExplainGame();

    //game loop
    while (dealer.IsGameOver(dealer.points) != true) {
        dealer.DisplayPoints();
        deck.GetCard();
        dealer.PlayCard(deck.newCard);
        dealer.GetGuess();
        deck.GetCard(); // <-- This might cause the old card to not be used properly if the player continues
        dealer.DisplayNextCard(deck.newCard);
        dealer.CalculatePoints(deck.newCard);
    }
    //ending message
    Console.WriteLine("Looks like you finally hit bottom. Thanks for playing.");
}

}

