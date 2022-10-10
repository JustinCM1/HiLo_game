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
        dealer.DisplayPoints(dealer.points);
        deck.GetCard(deck.newCard);
        dealer.PlayCard(dealer.oldCard);
        dealer.GetGuess(dealer.guess);
        deck.GetCard(deck.newCard);
        dealer.DisplayNextCard(deck.newCard, deck.newCard);
        deck.GetDiscardPile(deck.newCard);
        dealer.CalculatePoints(deck.newCard, dealer.points);
    }
    //ending message
    Console.WriteLine("Looks like you finally hit bottom. Thanks for playing.");
}

}

