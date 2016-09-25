using System;
using System.Collections.Generic;

namespace Homework1
{
	public class CardCountHand : Hand
	{

		public CardCountHand ()
		{
		}

		public int CompareHand (Hand h)
		{
			int counter;

			if (this.VALUES.Count >= h.VALUES.Count)
				counter = this.VALUES.Count;
			else
				counter = h.VALUES.Count;

			List<bool> thisInThat = new List<bool> ();
			List<bool> thatInThis = new List<bool> ();

			foreach (Card crd in this.VALUES) {
				if (h.ContainsCard (crd)) {
					thisInThat.Add (true);
				} else
					thisInThat.Add (false);
			}

			foreach (Card crd in h) {
				if (this.ContainsCard (crd)) {
					thatInThis.Add (true);
				} else
					thatInThis.Add (false);
			}

			bool thisIsInThat = thisInThat.Exists (true);
			bool thatIsInThis = thatInThis.Exists (true);

			if (thisIsInThat && thatIsInThis)
				return 0;
			else
				return -1;
		}

		public static void Main ()
		{

		}
	}
}

