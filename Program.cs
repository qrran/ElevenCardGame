using System;

namespace ElevenCardGame
{
	public class Program
	{

		static void Main()
		{
			//set up
			NPC computer = new NPC();
			Player player = new Player();
			Board board = new Board();

			//1. set up cards on board
			//computer.Shuffle();
			//computer.Print();
			board.AddCards(computer);
			//foreach (Card card in board.CardsOnBoard())
			//	Console.WriteLine(card.Rank + " " + card.Suit);
			//computer.Print();

			//2. player select cards
			Console.WriteLine("Pick the card (enter the rank - Ace, Two, Three, ...): ");
			string input = Console.ReadLine(); // Read the user's input as a string

			// Convert the user input to a Rank enum (assuming Rank is an enum)
			if (Enum.TryParse(input, out Rank selectedCardRank))
			{
				// If the conversion succeeds, call the SelectCards method with the selected card rank
				player.SelectCards(selectedCardRank);
			}
			else
			{
				// If the conversion fails, display an error message and prompt the user to try again
				Console.WriteLine("Invalid input. Please enter a valid card rank.");
			}
			
			player.SelectCards();


		}
		/////////Display//////////
		//cards on board
		//player input
		//number of cards remaining in NPC deck
		void CurrentCardsOnBoard()
		{
			foreach (Card card in board.CardsOnBoard())
				Console.WriteLine(card.Rank + " " + card.Suit);
		}

	}
}