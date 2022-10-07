



Deck deck = new Deck();

Score score = new Score();

bool gameOn = true;

int numGuesses = 0;

while (gameOn) {


    string currentCard = deck.DrawCard();

    Console.WriteLine($"The card is {currentCard}");

    Console.Write("Higher or lower? [h/l] ");

    string? guess = Console.ReadLine();

    string nextCard = deck.DrawNextCard();

    if (score.TestPlayerGuess(guess, currentCard, nextCard) == "correct") {

        score.CorrectGuessReward();

    } 
    else if (score.TestPlayerGuess(guess, currentCard, nextCard) == "wrong") {

        score.WrongGuessPunishment();

    }

    Console.WriteLine($"Next card was {nextCard}"); 

    score.DisplayScore();

    numGuesses++;

    Console.Write("Play again? [y/n] ");

    string? playAgain = Console.ReadLine();

    if (playAgain == "n") {
        gameOn = false; 
        Console.WriteLine("Game over, thanks for playing!");
    }

    if (score.IsGameOver()) {

        gameOn = false; 

    }

    Console.WriteLine(); 


}

Console.WriteLine($"You made {numGuesses} guesses"); 



