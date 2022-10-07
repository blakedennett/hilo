

class Deck {

    List<string> cards = new List<string>();

    public Deck() { 

  
        for (int i = 1; i <= 1000; i++) { 

            var random = new Random();

            int index = random.Next(1, 14);

            cards.Add(index.ToString());

        }
        

    }

    public void DisplayDeck() {
        
        foreach (string card in cards) {

            Console.WriteLine(card);

        }
    }

    public string DrawCard() {

        int cardsLength = cards.Count;

        string card = cards[cardsLength - 1];

        cards.RemoveAt(cards.Count - 1);

        return card; 

    }

    public string DrawNextCard() {

        int cardsLength = cards.Count;

        string card = cards[cardsLength - 1];

        return card; 

    }

}





