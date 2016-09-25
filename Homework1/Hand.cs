using System;
using System.Collections.Generic;

namespace Homework1
{
	abstract class Hand
	{

		private List<Card> hand;

 
		public Hand ()
		{
			hand = new List<Card> ();
		}

		public void AddCard (Card c)
		{
			hand.Add (c);
		}
	}
}

