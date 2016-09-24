using System;
using System.Collections.Generic;

namespace Homework1
{
	public class Card
	{
		private Suit s;
		private Rank r;

		public Card (Suit suit, Rank rank)
		{
			s = suit;
			r = rank;
		}

		public int CompareTo (Card OtherCardObject)
		{
			if (this.s.CompareTo (OtherCardObject.s) == 0 && this.r.CompareTo (OtherCardObject.r) == 0)
				return 0;
			else if (this.r.CompareTo (OtherCardObject.r) == -1)
				return -1;
			else
				return 1;
		}

		public static void Main ()
		{
			//Card c = new Card (Suit.CLUBS, Rank.ACE);
		}
	}
}

