class Score {

    int score = 300;

    public void DisplayScore() {

        Console.WriteLine($"Your current score is {score}"); 

    }

    public int WrongGuessPunishment() {

        score -= 75;

        return score;
    }

    public int CorrectGuessReward() {

        score += 100;

        return score;

    }

}