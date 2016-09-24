using System;
using System.Collections.Generic;

namespace Homework1
{
	public class Deck
	{
		private List<Card> dck;

		public Deck ()
		{
			dck = new List<Card> ();
		}

		public void AddCard(Card c)
		{
			dck.Add (c);
		}
			

		public static void Main ()
		{

		}
	}
}

