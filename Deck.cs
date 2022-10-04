

class Deck {

    List<string> cards = new List<string>();

    public Deck() { 

        for (int i = 1; i <= 4; i++) {

            for (int j = 1; j <= 13; j++) { 

                cards.Add(j.ToString());

            }

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

        cards.RemoveAt(index);

        Console.WriteLine(card);

        return card; 

    }

}





