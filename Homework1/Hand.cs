using System;
using System.Collections.Generic;

namespace Homework1
{
	public abstract class Hand
	{

		public List<Card> VALUES;

		public Hand ()
		{
			VALUES = new List<Card> ();
		}

		public void AddCard (Card c)
		{
			VALUES.Add (c);
		}

		public abstract int CompareHand (Hand OtherHandObject);

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
				if (this.VALUES [i].CompareTo(c) == 0)
					return i;
			}

			return -1;  //couldn't find card
		}

		public Card GetCardAtIndex (int ind)
		{
			return this.VALUES [ind];
		}

		public int GetNumberOfCards ()
		{
			return this.VALUES.Count;
		}

		public bool IsEmpty ()
		{
			if (this.VALUES.Count <= 0)
				return true;
			else
				return false;
		}

		public Card RemoveCard (Card c)
		{
			this.VALUES.Remove (c);
			return c;
		}

		public Card RemoveCard (int ind)
		{
			Card temp = this.VALUES [ind];
			this.VALUES.RemoveAt (ind);
			return temp;
		}

		public abstract int EvaluateHand ();

		public override string ToString ()
		{
			string output = "";
			foreach (Card crd in this.VALUES) {
				output += crd.ToString() + "\n";
			}
			return output;
		}
	}
}

