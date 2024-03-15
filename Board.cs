using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ElevenCardGame
{
	public class Board
	{
		//9 card slots
		List<Card> cardsOnBoard = new List<Card>();
		//// cards that computer has --- needs to make it local
		//NPC cardHoldByNPC = new NPC();
		// put 9 cards on board
		private int boardSize = 9;
		//check if board has all 9 cards
		private bool full;
		//check possibilities/how many valid combinations on board
		private int count = 0;
		//initialize Board with 9 cards
		public Board()
		{
			//default empty board
			full = false;
		}
		public List<Card> CardsOnBoard()
		{
			return cardsOnBoard;
		}

		//if cardsOnBoard is not full, NPC carHodByNPC.takeTopCard() add to board
		public bool Full()
		{
			if (cardsOnBoard.Count == boardSize)
				full = true;
			else if (cardsOnBoard.Count < boardSize)
				full = false;
			else if (cardsOnBoard.Count > boardSize)
			{
				cardsOnBoard.RemoveRange(boardSize, cardsOnBoard.Count - boardSize);
				throw new ArgumentException("Number of cards exceeds.");
			}
			return full;
		}
		public bool Empty()
		{
			return CardsOnBoard().Count == 0;
		}
		//check if there's any valid combination on board
		public int NumValidCombination()
		{
			// check posibilities for valid 11 combination
			for (int i = 0; i < boardSize; i++)
			{
				for (int j = 1; j < i; j++)
				{
					if (i + j == 11)
						count++;
				}
			}
			//J-11, Q-12, K-13
			int foundJ = 0;
			int foundQ = 0;
			int foundK = 0;

			if (cardsOnBoard != null)
			{
				//check possiblities for vaild JQK combination
				foreach (Card card in cardsOnBoard)
				{
					if (card.Rank == Rank.Jack)
						foundJ++;
					if (card.Rank == Rank.Queen)
						foundQ++;
					if (card.Rank == Rank.King)
						foundK++;
				}
				//if there's valid combination of JQK found
				if (foundJ > 0 && foundQ > 0 && foundK > 0)
				{
					int[] foundJQK = { foundJ, foundQ, foundK };
					//find min
					int min = foundJQK[0];
					foreach (int num in foundJQK)
					{
						// update minimum value if the current element is smaller
						if (num < min)
						{
							min = num;
						}
					}
					//update count to the number of JQK combination
					count += min;
				}
			}
			return count;
		}
		public bool HasValidCombination()
		{
			return NumValidCombination() > 0;
		}

		//add or remove cards if there's empty spaces on board
		//remove one card at a time
		public void RemoveCards(List<Card> selectedCards)
		{
			//create a copy
			List<Card> cardsToRemove = new List<Card>();
			// remove selected cards from cardsOnBoard
			foreach (Card card in selectedCards)
			{
				foreach (Card card2 in cardsOnBoard)
				{
					if (card.Rank == card2.Rank && card.Suit == card2.Suit)
					{
						cardsToRemove.Add(card2);
					}
				}
			}

			foreach (Card cardToRemove in cardsToRemove)
			{
				cardsOnBoard.Remove(cardToRemove);
			}

		}
		public void AddCards(Card card)
		{
			cardsOnBoard.Add(card);
		}

	}
}

