﻿using System;
using System.Collections.Generic;

namespace Homework1
{
	public class Deck
	{
		private List<Card> deck;
		private List<Card> rmDeck;

		public Deck ()
		{
			deck = new List<Card> ();
			rmDeck = new List<Card> ();
		}

		public void AddCard(Card c)
		{
			deck.Add (c);
		}
			
		public Card DealOne ()
		{

			Card tempCard = this.deck [0];
			this.rmDeck.Add (tempCard);
			this.deck.RemoveAt (0);
			return tempCard;
		}
			

		public int GetCardsRemaining ()
		{
			return deck.Count;
		}

		public int GetDeckSize()
		{
			return (deck.Count+rmDeck.Count);
		}

		public bool IsEmpty()
		{
			if (deck.Count <= 0)
				return true;
			else
				return true;
		}

		public void Shuffle()
		{
			int count = 3;
			while (count >= 3)
			{
			Random rnd = new Random ();
			for (int i = 0; i < deck.Count; i++) {
				Card temp = deck[i];
				int randomIndex = rnd.Next(i, deck.Count);
				deck[i] = deck[randomIndex];
				deck[randomIndex] = temp;
				} count --;
			}

		}

		public void RestoreDeck()
		{
			foreach (Card c in rmDeck) {
				deck.Add (rmDeck [0]);
				rmDeck.RemoveAt (0);
			}
		}

		/*public static void Main ()
		{
			Deck d = new Deck ();
			Card c1 = new Card (Suit.CLUBS, Rank.ACE);
			Card c2 = new Card (Suit.DIAMONDS, Rank.EIGHT);
			Card c3 = new Card (Suit.HEARTS, Rank.FIVE);

			d.AddCard (c1);
			d.AddCard (c2);
			d.AddCard (c3);

			Console.WriteLine (d.GetCardsRemaining());
			foreach (Card crd in d.deck) {
				Console.WriteLine (crd.ToString());
			}

			Card c4 = d.DealOne ();

			Console.WriteLine (d.GetCardsRemaining());
			foreach (Card crd in d.deck) {
				Console.WriteLine (crd.ToString());
			}

		}*/
	}
}

