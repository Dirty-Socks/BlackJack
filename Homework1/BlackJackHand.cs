using System;
using System.Collections.Generic;

namespace Homework1
{
	public class BlackJackHand : Hand
	{
		public BlackJackHand ()
		{
		}

		public override int CompareHand (Hand h)
		{
			if (this.EvaluateHand () == h.EvaluateHand ())
				return 0;
			else if (this.EvaluateHand () < h.EvaluateHand ())
				return -1;
			else
				return 1;
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
					value += 11;
					break;
				}
			}
			return value;
		}
	}
}

