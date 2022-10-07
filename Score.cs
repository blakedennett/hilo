class Score {

    int score = 300;

    public void DisplayScore() {

        Console.WriteLine($"Your score is {score}"); 

    }

    public string TestPlayerGuess(string guess, string currentCard, string nextCard) {

        int intCurrentCard = int.Parse(currentCard);

        int intNextCard = int.Parse(nextCard);


        if (intCurrentCard < intNextCard && guess == "h") {

            return "correct";

        }

        else if (intCurrentCard > intNextCard && guess == "l") {

            return "correct"; 

        }

        else if (intCurrentCard == intNextCard) {

            return "tie";

        }

        else {
            return "wrong";
        }
    }

    public int WrongGuessPunishment() {

        score -= 75;

        return score;
    }

    public int CorrectGuessReward() {

        score += 100;

        return score;

    }

    public bool IsGameOver() {

        if (score <= 0) {

            Console.WriteLine("Game over, thanks for playing!");
            
            return true;
        }
        else {
            return false;
        }


    }

}