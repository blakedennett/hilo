

class Deck {

    List<string> cards = new List<string>();

    public Deck() { 

  
        for (int i = 1; i <= 13; i++) { 

            cards.Add(i.ToString());

        }

    }

    public void DisplayDeck() {
        
        foreach (string card in cards) {

            Console.WriteLine(card);

        }
    }

    public string DrawCard() {

        var random = new Random();

        int index = random.Next(cards.Count);

        string card = cards[index];

        return card; 

    }

}





