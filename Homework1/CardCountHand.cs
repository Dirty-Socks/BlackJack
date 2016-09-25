using System;
using System.Collections.Generic;

namespace Homework1
{
	public class CardCountHand : Hand
	{

		public CardCountHand ()
		{
		}

		public override int CompareHand (Hand h)  //modify this to include evaluate method
		{
			List<bool> thisInThat = new List<bool> ();
			List<bool> thatInThis = new List<bool> ();

			foreach (Card crd in this.VALUES) {  
				if (h.ContainsCard (crd)) {
					thisInThat.Add (true);
				} else
					thisInThat.Add (false);
			}

			foreach (Card crd in h.VALUES) {  
				if (this.ContainsCard (crd)) {
					thatInThis.Add (true);
				} else
					thatInThis.Add (false);
			}

			/*
			foreach (bool b in thisInThat) {  //debugging
				Console.WriteLine (b.ToString ());
			}

			foreach (bool b in thatInThis) {  //debugging
				Console.WriteLine (b.ToString ());
			}
			*/

			bool thisIsInThat = !thisInThat.Exists (c => c == false);
			bool thatIsInThis = !thatInThis.Exists (c => c == false);

			if (thisIsInThat && thatIsInThis)
				return 0;
			else
				return -1;
		}

		public static void Main ()
		{
			CardCountHand cch = new CardCountHand ();
			Card c1 = new Card (Suit.CLUBS, Rank.ACE);
			Card c2 = new Card (Suit.DIAMONDS, Rank.KING);
			Card c3 = new Card (Suit.HEARTS, Rank.EIGHT);

			cch.AddCard (c1);
			cch.AddCard (c2);

			CardCountHand cch2 = new CardCountHand ();
			cch2.AddCard (c1);
			cch2.AddCard (c2);
			cch2.AddCard (c3);


			int output = cch.CompareHand (cch2);

			Console.WriteLine (output);
		}
	}
}

