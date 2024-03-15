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

		private bool valid;

		public NPC()
		{
		}

		public bool IsValid(List<Card> SelectedCards)
		{
			//size is 2 in this 11 card game, player selects 2 cards
			int selectedRank = 0;
			int numQueen = 0;
			//set combinationSize track on SelectedCards
			int combinationSize = SelectedCards.Count;

			foreach (Card card in SelectedCards)
			{
				selectedRank += (int)card.Rank;
				//check for number of Q
				if (card.Rank == Rank.Queen)
					numQueen++;
			}
			if (selectedRank == 11 && combinationSize == 2)
				valid = true;
			else if (selectedRank == 36 && combinationSize == 3 && numQueen == 1)
				valid = true;
			else
				valid = false;

			return valid;
		}
	}
}

