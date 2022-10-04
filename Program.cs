



Deck deck = new Deck();

Score score = new Score();

bool gameOn = true;

while (gameOn) {


    string currentCard = deck.DrawCard();

    Console.WriteLine($"The card is {currentCard}");

    Console.Write("Higher or lower? [h/l] ");

    string? guess = Console.ReadLine();

    string nextCard = deck.DrawCard();

    if (score.TestPlayerGuess(guess, currentCard, nextCard)) {

        score.CorrectGuessReward();

    } 
    else {

        score.WrongGuessPunishment();

    }

    Console.WriteLine($"Next card was {nextCard}"); 

    score.DisplayScore();

    Console.Write("Play again? [y/n] ");

    string playAgain = Console.ReadLine();

    if (playAgain == "n") {
        gameOn = false; 
        Console.WriteLine("Game over, thanks for playing!");
    }

    if (score.IsGameOver()) {

        gameOn = false; 

    }

    Console.WriteLine(); 


}



