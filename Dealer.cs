//In charge of tracking the most recently used card, the newest card, and how many points the player has
class Dealer {

    //initialize variables
    public int points = 0;
    public int newPoints = 0;

    public Dealer() {
        //starting value for player
        points = 300;
    }

    public int GetPoints(int points) {

        return points;
    }

    public int CalculatePoints(int points, int newPoints) {
        //if guess is correct, add to points with 
        //if guess is wrong, deduct points with input

        return newPoints;
    }
}