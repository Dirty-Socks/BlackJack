using System;
using System.Collections.Generic;

namespace Homework1
{
	public class Deck
	{
		private List<Card> deck;
		private List<Card> rmDeck;

		public Deck ()
		{
			deck = new List<Card> ();
		}

		public void AddCard(Card c)
		{
			deck.Add (c);
		}
			
		public Card DealOne ()
		{
			Card tempCard = deck [0];
			rmDeck.Add (deck [0]);
			deck.RemoveAt (0);
			return tempCard;
		}

		public int GetCardsRemaining ()
		{
			return deck.Count;
		}

		public int GetDeckSize()
		{
			return (deck.Count+rmDeck.Count);
		}

		public bool IsEmpty()
		{
			if (deck.Count <= 0)
				return true;
			else
				return true;
		}

		public void Shuffle()
		{
			Random rnd = new Random ();
			for (int i = 0; i < deck.Count; i++) {
				Card temp = deck[i];
				int randomIndex = rnd.Next(i, deck.Count);
				deck[i] = deck[randomIndex];
				deck[randomIndex] = temp;
			}

		}

		public void RestoreDeck()
		{
			foreach (Card c in rmDeck) {
				deck.Add (rmDeck [0]);
				rmDeck.RemoveAt (0);
			}
		}

		public static void Main ()
		{
			Deck d = new Deck ();
			Card c = new Card (Suit.HEARTS, Rank.ACE);
			Card c1 = new Card (Suit.HEARTS, Rank.KING);
			Card c2 = new Card (Suit.HEARTS, Rank.QUEEN);
			Card c3 = new Card (Suit.HEARTS, Rank.JACK);
			Card c4 = new Card (Suit.HEARTS, Rank.TEN);
			Card c5 = new Card (Suit.HEARTS, Rank.NINE);
			Card c6 = new Card (Suit.HEARTS, Rank.EIGHT);

			d.AddCard (c);
			d.AddCard (c1);
			d.AddCard (c2);
			d.AddCard (c3);
			d.AddCard (c4);
			d.AddCard (c5);
			d.AddCard (c6);

			foreach (Card crd in d.deck) {
				Console.WriteLine (crd.ToString());
			}
		}
	}
}

