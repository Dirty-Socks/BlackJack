using System;
using System.Collections.Generic;

namespace Homework1
{
	public class BlackJackGame
	{
		public BlackJackGame ()
		{
		}

		public void PlayGame ()
		{
			List<Card> d = new List<Card> ();

			Card c13 = new Card (Suit.CLUBS, Rank.ACE);
			Card c12 = new Card (Suit.CLUBS, Rank.KING);
			Card c11 = new Card (Suit.CLUBS, Rank.QUEEN);
			Card c10 = new Card (Suit.CLUBS, Rank.JACK);
			Card c9 = new Card (Suit.CLUBS, Rank.TEN);
			Card c8 = new Card (Suit.CLUBS, Rank.NINE);
			Card c7 = new Card (Suit.CLUBS, Rank.EIGHT);
			Card c6 = new Card (Suit.CLUBS, Rank.SEVEN);
			Card c5 = new Card (Suit.CLUBS, Rank.SIX);
			Card c4 = new Card (Suit.CLUBS, Rank.FIVE);
			Card c3 = new Card (Suit.CLUBS, Rank.FOUR);
			Card c2 = new Card (Suit.CLUBS, Rank.THREE);
			Card c1 = new Card (Suit.CLUBS, Rank.TWO);

			Card c26 = new Card (Suit.DIAMONDS, Rank.ACE);
			Card c25 = new Card (Suit.DIAMONDS, Rank.KING);
			Card c24 = new Card (Suit.DIAMONDS, Rank.QUEEN);
			Card c23 = new Card (Suit.DIAMONDS, Rank.JACK);
			Card c22 = new Card (Suit.DIAMONDS, Rank.TEN);
			Card c21 = new Card (Suit.DIAMONDS, Rank.NINE);
			Card c20 = new Card (Suit.DIAMONDS, Rank.EIGHT);
			Card c19 = new Card (Suit.DIAMONDS, Rank.SEVEN);
			Card c18 = new Card (Suit.DIAMONDS, Rank.SIX);
			Card c17 = new Card (Suit.DIAMONDS, Rank.FIVE);
			Card c16 = new Card (Suit.DIAMONDS, Rank.FOUR);
			Card c15 = new Card (Suit.DIAMONDS, Rank.THREE);
			Card c14 = new Card (Suit.DIAMONDS, Rank.TWO);

			Card c39 = new Card (Suit.HEARTS, Rank.ACE);
			Card c38 = new Card (Suit.HEARTS, Rank.KING);
			Card c37 = new Card (Suit.HEARTS, Rank.QUEEN);
			Card c36 = new Card (Suit.HEARTS, Rank.JACK);
			Card c35 = new Card (Suit.HEARTS, Rank.TEN);
			Card c34 = new Card (Suit.HEARTS, Rank.NINE);
			Card c33 = new Card (Suit.HEARTS, Rank.EIGHT);
			Card c32 = new Card (Suit.HEARTS, Rank.SEVEN);
			Card c31 = new Card (Suit.HEARTS, Rank.SIX);
			Card c30 = new Card (Suit.HEARTS, Rank.FIVE);
			Card c29 = new Card (Suit.HEARTS, Rank.FOUR);
			Card c28 = new Card (Suit.HEARTS, Rank.THREE);
			Card c27 = new Card (Suit.HEARTS, Rank.TWO);

			Card c52 = new Card (Suit.SPADES, Rank.ACE);
			Card c51 = new Card (Suit.SPADES, Rank.KING);
			Card c50 = new Card (Suit.SPADES, Rank.QUEEN);
			Card c49 = new Card (Suit.SPADES, Rank.JACK);
			Card c48 = new Card (Suit.SPADES, Rank.TEN);
			Card c47 = new Card (Suit.SPADES, Rank.NINE);
			Card c46 = new Card (Suit.SPADES, Rank.EIGHT);
			Card c45 = new Card (Suit.SPADES, Rank.SEVEN);
			Card c44 = new Card (Suit.SPADES, Rank.SIX);
			Card c43 = new Card (Suit.SPADES, Rank.FIVE);
			Card c42 = new Card (Suit.SPADES, Rank.FOUR);
			Card c41 = new Card (Suit.SPADES, Rank.THREE);
			Card c40 = new Card (Suit.SPADES, Rank.TWO);

			d.Add (c1);
			d.Add (c2);
			d.Add (c3);
			d.Add (c4);
			d.Add (c5);
			d.Add (c6);
			d.Add (c7);
			d.Add (c8);
			d.Add (c9);
			d.Add (c10);
			d.Add (c11);
			d.Add(c12);
			d.Add (c13);
			d.Add (c14);
			d.Add (c15);
			d.Add (c16);
			d.Add (c17);
			d.Add (c18);
			d.Add (c19);
			d.Add (c20);
			d.Add (c21);
			d.Add (c22);
			d.Add (c23);
			d.Add (c24);
			d.Add (c25);
			d.Add (c26);
			d.Add (c27);
			d.Add (c28);
			d.Add (c29);
			d.Add (c30);
			d.Add (c31);
			d.Add (c32);
			d.Add (c33);
			d.Add (c34);
			d.Add (c35);
			d.Add (c36);
			d.Add (c37);
			d.Add (c38);
			d.Add (c39);
			d.Add (c40);
			d.Add (c41);
			d.Add (c42);
			d.Add (c43);
			d.Add (c44);
			d.Add (c45);
			d.Add (c46);
			d.Add (c47);
			d.Add (c48);
			d.Add (c49);
			d.Add (c50);
			d.Add (c51);
			d.Add (c52);

			Deck mainDeck = new Deck ();

			for (int i = 0; i < 6; i++) {
				foreach (Card crd in d) {
					mainDeck.AddCard (crd);
				}
			}

			mainDeck.Shuffle ();

			BlackJackHand bjh1 = new BlackJackHand ();
			BlackJackHand bjh2 = new BlackJackHand ();

			bool gameInPlay = true;
			bool usersTurn = true;
			bool dealersTurn = true;

			int userScore;
			int dealerScore;

			bool userLost = false;

			//string message = "Your hand is: \n";
			while (gameInPlay) {
				//User's turn
				Console.WriteLine ("xxxxxxxxxxxxxxxx Your Turn xxxxxxxxxxxxxxxxxxxx");
				while (usersTurn) {
					bjh1.AddCard (mainDeck.DealOne ());
					userScore = bjh1.EvaluateHand ();
					Console.WriteLine ("Your hand is: \n"+bjh1.ToString());
					Console.WriteLine ("Your score is: \n"+userScore+"\n");
					
					if (bjh1.EvaluateHand () > 21) {
						//Console.WriteLine ("You lost, you loser.");
						usersTurn = false;
						userLost = true;
						break;
					}

					Console.WriteLine ("Hit or Stand? (h/s)");
					string line = Console.ReadLine ();
					if (line == "s" || line == "S") {
						usersTurn = false;
						break;
					}
				}

				Console.WriteLine ("xxxxxxxxxxxxxxxx Dealers Turn xxxxxxxxxxxxxxxxxxxx");
				//Dealer's turn
				while (dealersTurn) {
					bjh2.AddCard (mainDeck.DealOne ());
					dealerScore = bjh2.EvaluateHand ();
					Console.WriteLine ("Dealer's hand is: \n" + bjh2.ToString ());
					Console.WriteLine ("Dealer's score is: \n" + dealerScore+"\n");

					if (dealerScore >= 17) {
						dealersTurn = false;
						gameInPlay = false;
					}
				}
			}

			if (bjh1.CompareHand (bjh2) == 1 && !userLost)
				Console.WriteLine ("You won I think!");
			else if (bjh1.CompareHand(bjh2) == -1 && !userLost)
				Console.WriteLine ("You won I think!");
			else if (bjh1.CompareHand (bjh2) == 0)
				Console.WriteLine ("You tied?");
			else if (userLost)
				Console.WriteLine ("You lost I think");
			else if (bjh1.CompareHand(bjh2) == -1 && userLost)
				Console.WriteLine ("You lost I think");

		}
	}
}

