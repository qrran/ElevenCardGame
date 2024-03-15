using System;
using System.Drawing;

namespace ElevenCardGame
{
	//Computer NPC is short for Non Player Character
	public class NPC : Deck //inherited from Deck to use its funtionalities
	{
		//functionalities
		//1. has a deck of card, achieved by Deck inheritance
		//2. start/pause/end the game
		//3. distribute the card
		//4. check for validation
		//5. determine winner

		public NPC()
		{
		}

		public bool IsValid(List<Card> SelectedCards)
		{
			//if (SelectedCards == null || SelectedCards.Count != 2)
				//throw new ArgumentException("Invalid selection. Please select exactly 2 cards.");
			//size is 2 in this 11 card game, player selects 2 cards
			int selectedRank = 0;
			foreach (Card card in SelectedCards)
			{
				selectedRank += (int)card.Rank;
			}
			//valid rank
			//int expectedRank = 11;
			////J-11 + Q-12 + K-13 = 36
			//int expectedJQK = 36;
			//QQQ? = 36 too needs to exclude this case by specify count size

			return selectedRank == 11 || selectedRank == 36;
		}
	}
}

