using System;
using System.Collections.Generic;
using System.Text;

namespace CG_7_3
{
    public class Deck
{
        public Card[] Cards { get; set; }

        public Deck(int numberOfCards)
        {
            Cards = new Card[numberOfCards];
        }

    //need a method to draw a random card
        public Card Draw()
        {
        var random = new Random();
        var number = random.Next(Cards.Length);
        return Cards[number];
        }
    }
}
