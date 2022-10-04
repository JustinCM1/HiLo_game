//import libraries
using System;
using System.Collections.Generic;

//In charge of tracking what cards are played and what cards are left for the Dealer to draw from
class Deck {

    //intialize red cards
    public List<int> hearts = new List<int>(14);
    public List<int> diamonds = new List<int>(14);
    //initialize black cards
    public List<int> clubs = new List<int>(14);
    public List<int> spades = new List<int>(14);

    //full deck of all suits compiled together
    public List<int>deck = new List<int>(53);

    //other variables  
    public int newCard = 0;

    //constructor
    public Deck() {

        //fill the card values of the different suits into their respective lists
        for (int i = 1; i <= 13; i++) {
            hearts.Add(i);
            diamonds.Add(i);
            clubs.Add(i);
            spades.Add(i);
        }
        //fill the deck with the numbers of each suit
        for (int i = 0; i <= 13; i++) {
            deck.Add(hearts[i]);
            deck.Add(spades[i]);
            deck.Add(diamonds[i]);
            deck.Add(clubs[i]);
        }
    }

    //methods
    public int GetCard() {
        Random random = new Random();
        int newCard = random.Next(hearts.Count);
    
        return newCard;
    }

    public void DisplayDeck() {

        Console.WriteLine(deck.Count());
        for (int i = 0; i <= deck.Count(); i++) {
        Console.WriteLine($" Card number # {i}: {deck[i]}.");
        }
    }
}