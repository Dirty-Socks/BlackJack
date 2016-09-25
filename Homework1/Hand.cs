﻿using System;
using System.Collections.Generic;

namespace Homework1
{
	public class Hand
	{

		public List<Card> VALUES;  //don't forget to make abstract

 
		public Hand ()
		{
			VALUES = new List<Card> ();
		}

		public void AddCard (Card c)
		{
			VALUES.Add (c);
		}

		//public abstract int CompareHand (Hand OtherHandObject);

		public bool ContainsCard (Card c)
		{
			foreach (Card crd in this.VALUES) {
				if (crd.CompareTo (c) == 0) {
					return true;
				}
			}

			return false;
		}

		public void DiscardHand ()
		{
			this.VALUES.RemoveRange (0, this.VALUES.Count);	
		}

		public int FindCard (Card c)
		{
			for (int i = 0; i < this.VALUES.Count; i++) {
				if (this.VALUES [i].ToString () == c.ToString ())
					return i;
			}

			return -1;
		}

		public Card GetCardAtIndex (int ind)
		{
			return VALUES [ind];
		}

		public static void Main()
		{
			Hand h = new Hand ();
			Card c1 = new Card (Suit.CLUBS, Rank.FIVE);
			Card c2 = new Card (Suit.DIAMONDS, Rank.ACE);
			h.AddCard (c1);
			h.AddCard (c2);

			foreach (Card crd in h.VALUES) {
				Console.WriteLine(crd.ToString ());
			}

			h.DiscardHand ();

			foreach (Card crd in h.VALUES) {
				Console.WriteLine(crd.ToString ());
			}
		}
	}
}

