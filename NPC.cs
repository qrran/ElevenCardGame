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
		private static bool isRunning;
		//3. distribute the card
		//4. check for validation
		//5. determine winner

		public NPC()
		{
			isRunning = false;
		}

		//game starting
		public bool Start()
		{
			return isRunning = true;
		}
		//game stops, can be used for both paused and terminate
		public bool Stop()
		{
			return isRunning = false;
		}
		//check for validation, compare the sum of rank
		public bool IsValid(List<Card> SelectedCards)
		{
			if (SelectedCards == null || SelectedCards.Count != 2)
				throw new ArgumentException("Invalid selection. Please select exactly 2 cards.");
			//size is 2 in this 11 card game, player selects 2 cards
			int selectedRank = 0;
			for (int i = 0; i < SelectedCards.Count; i++)
			{
				selectedRank += (int)SelectedCards[i].Rank;
			}
			//valid rank
			int expectedRank = 11;
			//J-11 + Q-12 + K-13 = 36
			int expectedJQK = 36;

			return selectedRank == expectedRank || selectedRank == expectedJQK;
		}
		//if valid, remove the cards selected by player to from the computer deck
		//public void RemoveValidSelection(Board playBoard, List<Card> SelectedCards)
		//{
		//	if (IsValid(SelectedCards))
		//	{
		//		foreach (Card card in SelectedCards)
		//			playBoard.RemoveCards(card);
		//		Console.WriteLine("Valid combination! Cards have been removed.");
		//	}
		//	else
		//		Console.WriteLine("Combination is not valid. Please try again.");
		//}
	}
}

