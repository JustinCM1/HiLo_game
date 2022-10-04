
//In charge of tracking what cards are played and what cards are left for the Dealer to draw from
class Deck {

//intialize red cards
        public List<int> hearts = new List<int>();
        public List<int> diamonds = new List<int>();
        //initialize black cards
        public List<int> clubs = new List<int>();
        public List<int> spades = new List<int>();
    public Deck() {

        //fill the card values of the different suits into their respective lists
        for (int i = 1; i <= 13; i++) {
            hearts.Add(i);
            diamonds.Add(i);
            clubs.Add(i);
            spades.Add(i);
        }
    }
}