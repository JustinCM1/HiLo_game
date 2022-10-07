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
        dealer.PlayCard(dealer.oldCard);
        dealer.GetGuess();
        deck.GetCard();
        dealer.DisplayNextCard(deck.newCard);
        deck.GetDiscardPile();
        dealer.CalculatePoints(deck.newCard);
    }
    //ending message
    Console.WriteLine("Looks like you finally hit bottom. Thanks for playing.");
}

}

