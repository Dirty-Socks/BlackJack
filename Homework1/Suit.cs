using System;
using System.Collections.Generic;

namespace Homework1
{
	public class Suit
	{

		private string _name;
		private string _symbol;

		public static Suit CLUBS;
		public static Suit DIAMONDS;
		public static Suit SPADES;
		public static Suit HEARTS;

		public static List<Suit> VALUES = new List<Suit>();

		static Suit ()
		{
			CLUBS = new Suit ("Clubs", "C");
			DIAMONDS = new Suit ("Diamonds", "D");
			HEARTS = new Suit ("Hearts", "H");
			SPADES = new Suit ("Spades", "S");

			VALUES.Add (CLUBS);
			VALUES.Add (DIAMONDS);
			VALUES.Add (HEARTS);
			VALUES.Add (SPADES);
		}

		public Suit	(string nam, string sym)
		{
			this._name = nam;
			this._symbol = sym;
		}

		public int CompareTo (Suit OtherSuitObject)
		{
			if (VALUES.IndexOf (this) == VALUES.IndexOf (OtherSuitObject))
				return 0;
			else
				return -1;
		}

		public string GetSymbol ()
		{
			return _symbol;
		}

		public string GetName ()
		{
			return _name;
		}

		public override string ToString ()
		{
			return _name;
		}
	}
}

