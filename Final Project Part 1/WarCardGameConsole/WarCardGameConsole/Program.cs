///Rachel Brinkley
///Final Project Part 1
///Date to turn in 4/18/2021
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using static System.Console;


namespace WarCardGameConsole
{
    class Program
    {
        private static List<string> list1; //list for card one with suit value and rank value used to find face and suit string
        private static List<string> list2; //list for card two with suit value and rank value used to find face and suit string
        private static int scorePlayer1 = 0;
        private static int scorePlayer2 = 0;
        private static string playAgain = "Y";
        private static string winner = " ";


        static void Main(string[] args)
        {
            //Create when txt file when it does not exist and/or opens file
            FileStream outFile = new FileStream("RachelBrinkleyResults.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);

            //set up the program to run again when player wants to play again using a while loop that calls the method RunProgram
            while (playAgain.ToUpper() == "Y")
            {
                RunProgram();
                Console.WriteLine("FINAL SCORE");
                Console.WriteLine("\tComputer's score is: " + scorePlayer1);
                Console.WriteLine("\tPlayer's score is: " + scorePlayer2);
                
                if (scorePlayer1 > scorePlayer2)
                {
                    Console.WriteLine("Computer Won!");
                    winner = "Computer Won!";
                }
                else if (scorePlayer2 > scorePlayer1)
                {
                    Console.WriteLine("You win!");
                    winner = "Player won!";
                }
                else
                {
                    Console.WriteLine("It is a tie.");
                    winner = "It was a tie.";
                }
                Console.WriteLine(" \n ");

                Console.WriteLine("Do you want to play again? (Y / N)");
                playAgain = Console.ReadLine();

                //write to file
                writer.WriteLine("Computer's score is: " + scorePlayer1);
                writer.WriteLine("Player's score is: " + scorePlayer2);
                writer.WriteLine(winner);
                
                


                //reset scores to zero
                scorePlayer1 = 0;
                scorePlayer2 = 0;

            }

            //closing writer and txt file
            writer.Close();
            outFile.Close();

            System.Environment.Exit(0);

        }


        public static string RunProgram()
        {
            //Start by making a deck of cards by calling FillDeck()
            string[] Deck = DealCards.FillDeck();

            //Deal 26 hands from the deck but program really draws two cards at randum from deck each deal then repeats
            for (var deal = 1; deal <= 26; deal++)
            {
                Console.WriteLine("Deal hand " + deal + ".\n");

                //First player selects a random card from the deck calling method DealCards.SelectCard()
                int card1 = DealCards.SelectCard();

                //Second player selects a random card from the deck calling method DealCards.SelectCard()
                int card2 = DealCards.SelectCard();


                //chnage card from array to a list of strings with suit and rank values
                list1 = Deck[card1].Split().ToList();
                list2 = Deck[card2].Split().ToList();

                //convert rank as string to value as int
                int value1 = Convert.ToInt32(list1.ElementAt(1)); //gets value which is second item ElementAt(1) for card1
                int value2 = Convert.ToInt32(list2.ElementAt(1)); //gets value which is second item ElementAt(1) for card2

                //convert suit and rank values to strings of suit and face discriptions
                int rank1 = Convert.ToInt32(list1.ElementAt(1));
                string face1 = DealCards.FindFace(rank1); //get the face of the card by calling FindFace() to get face as string from rank as value

                int cardSuit1 = Convert.ToInt32(list1.ElementAt(0)); // get the suit of the card by calling FindSuit() to get suit as string from suit as value
                string suit1 = DealCards.FindSuit(cardSuit1);

                int rank2 = Convert.ToInt32(list2.ElementAt(1));//get the face of the card by calling FindFace() to get face as string from rank as value
                string face2 = DealCards.FindFace(rank2);

                int cardSuit2 = Convert.ToInt32(list2.ElementAt(0));// get the suit of the card by calling FindSuit() to get suit as string from suit as value
                string suit2 = DealCards.FindSuit(cardSuit2);

                //write the face and suit descriptions to console
                Console.WriteLine("\tThe Computer has a: ");
                //Console.WriteLine(Deck[card1]);
                Console.WriteLine("\t" + face1 + " of " + suit1 + "\n"); //write to console the face and suit of the card

                Console.WriteLine("\tThe Player has a: ");
                //Console.WriteLine(Deck[card2]);
                Console.WriteLine("\t" + face2 + " of " + suit2 + "\n");//write to console the face and suit of the card

                //Compare values and score game
                if (value1 > value2)
                {
                    scorePlayer1 = scorePlayer1 + 2;
                    Console.WriteLine("\tThe Computer wins this hand!\n");
                }
                else if (value1 < value2)
                {
                    scorePlayer2 = scorePlayer2 + 2;
                    Console.WriteLine("\tThe Player wins this hand!\n");
                }
                else if (value1 == value2)
                {
                    scorePlayer1 = scorePlayer1 + 1;
                    scorePlayer2 = scorePlayer2 + 1;
                    Console.WriteLine("\tIt is a tie this hand!\n");
                }

                Console.WriteLine("\tComputer's score is: " + scorePlayer1);
                Console.WriteLine("\tPlayer's score is: " + scorePlayer2);

                Console.ReadLine(); //pause game after each deal
            }

            return null;
        }
    }
}



