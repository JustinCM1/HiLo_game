//import libraries
using System;
using System.Collections.Generic;

//In charge of tracking what cards are played and what cards are left for the Dealer to draw from
class Deck {

    //intialize red cards
    public List<int> hearts = new List<int>();
    public List<int> diamonds = new List<int>();
    //initialize black cards
    public List<int> clubs = new List<int>();
    public List<int> spades = new List<int>();

    //full deck of all suits compiled together
    public List<int>deck = new List<int>();

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
        for (int i = 1; i <= 11; i++) {
            deck.Add(hearts[i]);
        }
        for (int i = 1; i <= 11; i++) {
            deck.Add(diamonds[i]);
        }
        for (int i = 1; i <= 11; i++) {
            deck.Add(clubs[i]);
        }
        for (int i = 1; i <= 11; i++) {
            deck.Add(spades[i]);
        }
    }

    //methods
    public int GetCard() {
        Random random = new Random();
        int newCard = random.Next(hearts.Count);
    
        return newCard;
    }

    public void displayDeck() {
        Console.WriteLine($"{deck}.");
    }
}