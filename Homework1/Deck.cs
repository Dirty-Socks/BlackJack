using System;
using System.Collections.Generic;

namespace Homework1
{
	public class Deck
	{
		private List<Card> dck;
		private int _fullDeckCount = 0;

		public Deck ()
		{
			dck = new List<Card> ();
		}

		public void AddCard(Card c)
		{
			dck.Add (c);
			_fullDeckCount++;
		}
			
		public Card DealOne ()
		{
			Card tempCard = dck [0];
			dck.RemoveAt (0);
			return tempCard;
		}

		public int GetCardsRemaining ()
		{
			return dck.Count;
		}

		public int GetDeckSize()
		{
			return _fullDeckCount;
		}

		public bool IsEmpty()
		{
			if (dck.Count <= 0)
				return true;
			else
				true;
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

