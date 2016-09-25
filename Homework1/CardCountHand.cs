using System;
using System.Collections.Generic;

namespace Homework1
{
	public class CardCountHand : Hand
	{

		public CardCountHand ()
		{
		}

		public override int CompareHand (Hand h)
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

			//everything in this hand exists in that hand
			bool thisIsInThat = !thisInThat.Exists (c => c == false);
			//everything in that hand exists in that hand
			bool thatIsInThis = !thatInThis.Exists (c => c == false);

			if (thisIsInThat && thatIsInThis)
				return 0;
			else
				return -1;
		}

		public override int EvaluateHand ()
		{
			int value = 0;
			foreach (Card crd in this.VALUES) {
				string sym = crd.GetRank ().GetSymbol ();
				switch (sym) {
					case "2":
						value += 2;
						break;
					case "3":
						value += 3;
						break;
					case "4":
						value += 4;
						break;
					case "5":
						value += 5;
						break;
					case "6":
						value += 6;
						break;
					case "7":
						value += 7;
						break;
					case "8":
						value += 8;
						break;
					case "9":
						value += 9;
						break;
					case "10":
						value += 10;
						break;
					case "J":
						value += 10;
						break;
					case "Q":
						value += 10;
						break;
					case "K":
						value += 10;
						break;
					case "A":
						value += 1;
						break;
					}
			}
			return value;
		}

		public static void Main ()
		{
			CardCountHand cch = new CardCountHand ();
			Card c1 = new Card (Suit.CLUBS, Rank.ACE);
			Card c2 = new Card (Suit.DIAMONDS, Rank.KING);
			Card c3 = new Card (Suit.HEARTS, Rank.EIGHT);

			cch.AddCard (c1);
			cch.AddCard (c2);
			cch.AddCard (c3);


			int output = cch.EvaluateHand ();

			Console.WriteLine (output);
		}
	}
}

