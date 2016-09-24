using System;
using System.Collections.Generic;

namespace Homework1
{
	public class Suit
	{

		public static string _name;
		public static string _symbol;

		public static Suit CLUBS;
		public static Suit DIAMONDS;
		public static Suit SPADES;
		public static Suit HEARTS;

		public static List<Suit> VALUES = new List<Suit>();

		static Suit ()
		{
			CLUBS = new Suit ("Clubs", "C");
			DIAMONDS = new Suit ("Diamonds", "D");
			HEARTS = new Suit ("HEARTS", "H");
			SPADES = new Suit ("Spades", "S");
		}

		public Suit	(string nam, string sym)
		{
			_name = nam;
			_symbol = sym;
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

