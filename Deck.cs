//import libraries
using System;
using System.Collections.Generic;

//In charge of tracking what cards are played and what cards are left for the Dealer to draw from
class Deck {
    //intialize different suits
    public List<int> hearts = new List<int>();
    public List<int> diamonds = new List<int>();
    public List<int> clubs = new List<int>();
    public List<int> spades = new List<int>();

    //full deck of all suits compiled together
    public List<int> deck = new List<int>();
    public List<int> discard = new List<int>();

    //other variables  
    public int newCard = 0;
    Random random = new Random();

    //constructor
    public Deck() {

        //fill the card values of the different suits into their respective lists
        for (int i = 0; i <= 13; i++) {
            hearts.Add(i);
            diamonds.Add(i);
            clubs.Add(i);
            spades.Add(i);
        }
        //fill the deck with the numbers of each suit
        /*Could make a cheater option and make a single list of deck with 52 cards
          but this restricts the ability to include future implementation of suits*/
        for (int i = 0; i <= 13; i++) {
            deck.Add(hearts[i]);
            deck.Add(spades[i]);
            deck.Add(diamonds[i]);
            deck.Add(clubs[i]);
        }
    }

    /************| METHODS |****************/
    public int GetCard() {
        int newCard = random.Next(deck.Count);
    
        return newCard;
    }

    //keep track of what cards are still in the deck and what has been played already
    public void GetDiscardPile() {
        //subract from the deck list to add to the discard list
        discard.Add(newCard);
        deck.Remove(newCard);
    }
}