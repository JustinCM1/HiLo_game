//In charge of running the game
class Hilo {

static void Main(string[] args) {

    //variables    
    Dealer dealer = new Dealer();

    dealer.GetPoints(dealer.points);
    Console.WriteLine($"Points: {dealer.points}");
    Console.Write("Available cards: ");
    for (int i = 0; i < 52; i++) {
        Console.Write($"{deck.hearts[i]}");
    }
    

    }
}