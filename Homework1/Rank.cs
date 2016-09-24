using System;
using System.Collections.Generic;

namespace Homework1
{
	public class Rank
	{
		public string _name;
		public string _symbol;

		public static Rank TWO;
		public static Rank THREE;
		public static Rank FOUR;
		public static Rank FIVE;
		public static Rank SIX;
		public static Rank SEVEN;
		public static Rank EIGHT;
		public static Rank NINE;
		public static Rank TEN;
		public static Rank JACK;
		public static Rank QUEEN;
		public static Rank KING;
		public static Rank ACE;

		public static List<Rank> VALUES = new List<Rank>();

		static Rank ()
		{
			TWO = new Rank("Two","2");
			THREE = new Rank("Three","3");
			FOUR = new Rank("Four","4");
			FIVE = new Rank ("Five", "5");
			SIX = new Rank("Six","6");
			SEVEN = new Rank("Seven","7");
			EIGHT = new Rank("Eight","8");
			NINE = new Rank("Nine","9");
			TEN = new Rank("Ten","10");
			JACK = new Rank("Jack","J");
			QUEEN = new Rank("Queen","Q");
			KING = new Rank("King","K");
			ACE = new Rank("Ace","A");

			VALUES.Add (TWO);
			VALUES.Add (THREE);
			VALUES.Add (FOUR);
			VALUES.Add (FIVE);
			VALUES.Add (SIX);
			VALUES.Add (SEVEN);
			VALUES.Add (EIGHT);
			VALUES.Add (NINE);
			VALUES.Add (TEN);
			VALUES.Add (JACK);
			VALUES.Add (QUEEN);
			VALUES.Add (KING);
			VALUES.Add (ACE);
		}

		public Rank (string nam, string sym)
		{
			_name = nam;
			_symbol = sym;
		}

		public int CompareTo (Rank OtherRankObject)
		{
			int objA = VALUES.IndexOf (this);
			int objB = VALUES.IndexOf (OtherRankObject);

			if (objA == objB)
				return 0;
			else if (objA < objB)
				return -1;
			else
				return 1;
		}

		public string GetSymbol ()
		{
			return this._symbol;
		}

		public string GetName()
		{
			return this._name;
		}

		public override string ToString()
		{
			return this._name;
		}
	}
}

