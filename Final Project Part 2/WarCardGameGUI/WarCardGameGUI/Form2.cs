using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;


namespace WarCardGameGUI
{
    public partial class GameWindow : Form
    {
        private static List<string> list1; //list for card one with suit value and rank value used to find face and suit string
        private static List<string> list2; //list for card two with suit value and rank value used to find face and suit string
        private static int scorePlayer1 = 0;
        private static int scorePlayer2 = 0;
        private static int deal;
        string[] Deck;


        static Random ranCard = new Random();
        static List<int> dealtCards = new List<int>();



        public GameWindow()
        {
            InitializeComponent();
        }

        private void BtnDeal_Click(object sender, EventArgs e)
        {
            Random ranCard = new Random();
            List<int> dealtCards = new List<int>();
            string[] cardsInDeck = new string[52];
            int index = 0;
            deal = 1;
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

            Deck = cardsInDeck;
            BtnDeal.Visible = false;  //Change Deal button from visible to hidden
            LbDeal.Visible = false;   
            BtnPlay.Visible = true;  //Change PLay button from hidden to visible
            LbPlay.Visible = true; 

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (deal <= 26)
            {
                if ((deal - 1) % 4 == 0)
                {
                    TxtGame.Text = ""; // clear the text box after 4 hands are played
                }


                TxtGame.AppendText("Deal hand " + deal + "\r\n");

                //First player selects a random card from the deck calling method DealCards.SelectCard()
                int card1 = SelectCard();

                //Second player selects a random card from the deck calling method DealCards.SelectCard()
                int card2 = SelectCard();


                //chnage card from array to a list of strings with suit and rank values
                list1 = Deck[card1].Split().ToList();
                list2 = Deck[card2].Split().ToList();

                //convert rank as string to value as int
                int value1 = Convert.ToInt32(list1.ElementAt(1)); //gets value which is second item ElementAt(1) for card1
                int value2 = Convert.ToInt32(list2.ElementAt(1)); //gets value which is second item ElementAt(1) for card2

                //convert suit and rank values to strings of suit and face discriptions
                int rank1 = Convert.ToInt32(list1.ElementAt(1));
                string face1 = FindFace(rank1); //get the face of the card by calling FindFace() to get face as string from rank as value

                int cardSuit1 = Convert.ToInt32(list1.ElementAt(0)); // get the suit of the card by calling FindSuit() to get suit as string from suit as value
                string suit1 = FindSuit(cardSuit1);

                int rank2 = Convert.ToInt32(list2.ElementAt(1));//get the face of the card by calling FindFace() to get face as string from rank as value
                string face2 = FindFace(rank2);

                int cardSuit2 = Convert.ToInt32(list2.ElementAt(0));// get the suit of the card by calling FindSuit() to get suit as string from suit as value
                string suit2 = FindSuit(cardSuit2);

                //write the face and suit descriptions to console
                TxtGame.AppendText("Computer has: ");

                TxtGame.AppendText(face1 + " of " + suit1 + "\r\n"); //write to console the face and suit of the card

                TxtGame.AppendText("Player has: ");

                TxtGame.AppendText(face2 + " of " + suit2 + "\r\n");//write to console the face and suit of the card

                //Compare values and score game
                if (value1 > value2)
                {
                    scorePlayer1 = scorePlayer1 + 2;
                    TxtGame.AppendText("Computer wins this hand!\r\n");
                }
                else if (value1 < value2)
                {
                    scorePlayer2 = scorePlayer2 + 2;
                    TxtGame.AppendText("Player wins this hand!\r\n");
                }
                else if (value1 == value2)
                {
                    scorePlayer1 = scorePlayer1 + 1;
                    scorePlayer2 = scorePlayer2 + 1;
                    TxtGame.AppendText("It is a tie this hand!\r\n");
                }

                TxtGame.AppendText("Computer's score: " + scorePlayer1 + "\r\n");
                TxtGame.AppendText("Player's score: " + scorePlayer2 + "\r\n");

                if(deal == 26)
                {
                    TxtGame.AppendText("\r\nFINAL SCORE");
                    TxtGame.AppendText("\r\nComputer's score: " + scorePlayer1);
                    TxtGame.AppendText("\r\nPlayer's score: " + scorePlayer2);

                    if (scorePlayer1 > scorePlayer2)
                    {
                        TxtGame.AppendText("\r\nComputer Won!");
                    }
                    else if (scorePlayer2 > scorePlayer1)
                    {
                        TxtGame.AppendText("\r\nYou win!");
                    }
                    else
                    {
                        TxtGame.AppendText("\r\nIt is a tie.");
                    }

                    BtnEnd.Visible = true;  //Change PLay button from hidden to visible
                    LbEnd.Visible = true;
                    BtnPlay.Visible = false;  //Change PLay button from hidden to visible
                    LbPlay.Visible = false;

                }

                deal++;

            }




            //this method randomly draws a card from a deck and checks to see if it has been played before, if not the card is choosen
            int SelectCard()
            {
                //restet the number of dealt cards by clearing the dealtCards list to reset for a new game
                if (dealtCards.Count == 52)
                {
                    dealtCards.Clear();
                }

                int dealtCard = ranCard.Next(0, 52);

                while (dealtCards.Contains(dealtCard))
                {
                    dealtCard = ranCard.Next(0, 52);
                }

                int card = dealtCard;
                dealtCards.Add(card);

                return card;
            }


            //this method converts a rank value to a string of a card face description
            string FindFace(int cardRank)
            {
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

            //this mthod converts a suit value to string suit description
            string FindSuit(int cardSuit)
            {
                string foundSuit;

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

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

