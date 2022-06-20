using System;
using System.IO;
using System.Collections.Generic;


namespace WarCardGameConsole
{


    class DealCards
    {
        static Random ranCard = new Random();
        static List<int> dealtCards = new List<int>();



        public static string[] FillDeck()
        {
            //Creates a deck of cards
            string[] cardsInDeck = new string[52];
            int index = 0;
            {
                for (var suit = 0; suit <= 3; suit++)
                {
                    for (var rank = 0; rank <= 12; rank++)
                    {
                        cardsInDeck[index] = suit.ToString() + (" ") + rank.ToString();
                        index++;
                    }


                }


            }

            return cardsInDeck;
        }



        public static int SelectCard()
        {
            //restet the number of dealt cards by clearing the dealtCards list to reset for a new game
            if (dealtCards.Count == 52)
            {
                dealtCards.Clear();
            }

            int dealtCard = ranCard.Next(0, 52);

            //ensures only random cards that have not been used are selected
            while (dealtCards.Contains(dealtCard))
            {
                dealtCard = ranCard.Next(0, 52);
            }

            int card = dealtCard;
            dealtCards.Add(card);

            return card;
        }



        public static string FindFace(int cardRank)
        {
            //converts card ranks to card faces
            string face = "";
            cardRank = cardRank + 1;

            if (cardRank == 1)
                face = "Ace";
            else if (cardRank == 11)
                face = "Jack";
            else if (cardRank == 12)
                face = "Queen";
            else if (cardRank == 13)
                face = "King";
            else
                face = cardRank.ToString();

            return face;
        }


        public static string FindSuit(int cardSuit)
        {
            string foundSuit;

            //converts suit value to card suit strings

            if (cardSuit == 0)
                foundSuit = "Diamonds";
            else if (cardSuit == 1)
                foundSuit = "Hearts";
            else if (cardSuit == 2)
                foundSuit = "Clubs";
            else
                foundSuit = "Spades";

            return foundSuit;
        }

    }
}
