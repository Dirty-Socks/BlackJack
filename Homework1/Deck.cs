using System;
using System.Collections.Generic;

namespace Homework1
{
	public class Deck
	{
		private List<Card> deck;
		private List<Card> rmDeck;
		private int _fullDeckCount = 0;

		public Deck ()
		{
			deck = new List<Card> ();
		}

		public void AddCard(Card c)
		{
			deck.Add (c);
			_fullDeckCount++;
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
				true;
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
			Card c = new Card (Suit.HEARTS, Rank.KING);
			d.AddCard (c);

			Card e = d.DealOne ();
			Console.WriteLine (e.ToString ());
		}
	}
}

