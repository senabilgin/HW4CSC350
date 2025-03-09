using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Deck
{
    List<Card> cards = new List<Card>();
    private Random random = new Random();

    //Deck Constructor
    public Deck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                //create a new card and add it to the 
                cards.Add(new Card(rank, suit));

            }
        }
    }

    //Implement a property to get Cards
    public List<Card> Cards => cards;


    //Takes top card from deck (if deck is not empty, otherwise return null)
    public Card TakeTopCard()
    {
        //implementation
        if (cards.Count == 0) return null;
        Card topCard = cards[^1];
        cards.RemoveAt(cards.Count - 1);
        return topCard;
    }

    //Shuffle Method
    public void Shuffle()
    {
        //implementation
        for (int i = 0; i < cards.Count; i++)
        {
            int j = random.Next(cards.Count);
            (cards[i], cards[j]) = (cards[j], cards[i]); // Swap
        }
    }

    //Cut method
    public void Cut(int index)
    {
        //implementation
        if (index < 0 || index >= cards.Count) return;

        List<Card> top = cards.GetRange(0, index);
        List<Card> bottom = cards.GetRange(index, cards.Count - index);

        cards.Clear();
        cards.AddRange(bottom);
        cards.AddRange(top);
    }
}


