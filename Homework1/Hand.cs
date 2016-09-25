using System;
using System.Collections.Generic;

namespace Homework1
{
	public class Hand
	{

		public List<Card> hand;  //don't forget to make abstract

 
		public Hand ()
		{
			hand = new List<Card> ();
		}

		public void AddCard (Card c)
		{
			hand.Add (c);
		}

		//public abstract int CompareHand (Hand OtherHandObject);

		public bool ContainsCard (Card c)
		{
			foreach (Card crd in this.hand) {
				if (crd.CompareTo (c) == 0) {
					return true;
				}
			}

			return false;
		}

		public static void Main()
		{
			Hand h = new Hand ();
			Card c1 = new Card (Suit.CLUBS, Rank.FIVE);
			Card c2 = new Card (Suit.DIAMONDS, Rank.ACE);
			h.AddCard (c1);
			h.AddCard (c2);

			Card c3 = new Card (Suit.HEARTS, Rank.KING);

			bool output = h.ContainsCard (c3);
			if (output)
				Console.WriteLine ("did contain card");
			else
				Console.WriteLine ("did not contain card");
		}
	}
}

