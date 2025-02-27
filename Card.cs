using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Card
{
    //Fields, example: Rank rank;
    //check the help documentation for the fields
    private Rank rank;
    private Suit suit;
    private bool isFaceUp;

    //Card Constructor
public Card(Rank rank, Suit suit)
    {
        this.rank = rank;
        this.suit = suit;
        isFaceUp = false;
    }

    //Define properties for all above fields
    //code example: public Suit Suit { get { return suit; } }
        public Rank Rank => rank;
    public Suit Suit => suit;
    public bool IsFaceUp => isFaceUp;
 public Card(Rank rank,)

    public void FlipOver()
    {
        //implementation 
                isFaceUp = !isFaceUp;

    }
        
}
