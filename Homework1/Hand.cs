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

		public void DiscardHand ()
		{
			this.hand.RemoveRange (0, this.hand.Count);	
		}

		public int FindCard (Card c)
		{
			for (int i = 0; i < this.hand.Count; i++) {
				if (this.hand [i].ToString () == c.ToString ())
					return i;
			}

			return -1;
		}

		public static void Main()
		{
			Hand h = new Hand ();
			Card c1 = new Card (Suit.CLUBS, Rank.FIVE);
			Card c2 = new Card (Suit.DIAMONDS, Rank.ACE);
			h.AddCard (c1);
			h.AddCard (c2);

			foreach (Card crd in h.hand) {
				Console.WriteLine(crd.ToString ());
			}

			h.DiscardHand ();

			foreach (Card crd in h.hand) {
				Console.WriteLine(crd.ToString ());
			}
		}
	}
}

