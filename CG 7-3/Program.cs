using System;

namespace CG_7_3
{
    class Program
    {
        static void Main(string[] args)
        {//create a deck of cards
            Deck deck = new Deck(52);
            Card myCard = new Card();
            
            int counter = 0;

            // loop through face values
            for (int i = 2; i <= 14; i++)
            {
                //loop through the suits
                for (int j=1; j <= 4; j++)

                {
                    // set the face value
                    string faceValue;

                    if (i < 11) faceValue = i.ToString();
                    else if (i == 11) faceValue = "Jack";
                    else if (i == 12) faceValue = "Queen";
                    else if (i == 13) faceValue = "King";
                    else faceValue = "Ace";

                    // set the suit
                    string suit;

                    if (j == 1) suit = "Hearts";
                    else if (j == 2) suit = "Diamonds";
                    else if (j == 3) suit = "Spades";
                    else suit = "Clubs";
                    deck.Cards[counter] = new Card
                    {
                        FaceValue = faceValue,
                        Suit = suit,
                    };
                    counter++;
                }
                // draw a card
                var card = deck.Draw();
                // show the value
                

                Console.WriteLine(myCard.GetFullName());

                Console.ReadLine();




            }
        }
    }
}
