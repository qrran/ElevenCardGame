using System;

namespace ElevenCardGame
{
	public class Program
	{

		public static void Main()
		{
			//set up
			NPC computer = new NPC();
			Player player = new Player("Player 1");
			Board board = new Board();

			Console.WriteLine($"Welcome to Eleven Card Game! {player.Name}\n");
			Console.WriteLine("Select cards with total rank equals to 11 ");
			Console.WriteLine("until there's no more cards left to win the game!");

			//1. set up cards on board
			//computer.Shuffle();
			//computer.Print();
			//board.AddCards(computer.TakeTopCard());
			//add up to 9 cards
			while (!board.Full() && board.CardsOnBoard().Count < 9)
			{
				board.AddCards(computer.TakeTopCard());
			}
			CurrentCardsOnBoard(board);

			Console.WriteLine("\nPick a card: ");
			string input = Console.ReadLine();
			Card selectedCard = Card.Parse(input);
			Console.WriteLine($"You have selected{selectedCard.Rank} {selectedCard.Suit}");
			//List<Card> selectedCardList = new List<Card>();
			player.SelectCards(selectedCard);
			//Console.WriteLine("selected: " + player.SelectCards(selectedCard));
			board.RemoveCards(player.GetSelectedCards());
			CurrentCardsOnBoard(board);

			//2. player select cards until the game is over
			//while (!GameOver(computer, board))
			//{
			//	Console.WriteLine("\nPick a card: ");
			//	string input = Console.ReadLine();
			//	Card selectedCard = Card.Parse(input);
			//	List<Card> selectedCardList = new List<Card>();
			//	selectedCardList.Add(selectedCard);
			//	// Parse the input string into a Card object
			//	try
			//	{
			//		player.SelectCards(selectedCard);
			//		board.RemoveCards(selectedCardList);
			//		CurrentCardsOnBoard(board);
			//	}
			//	catch (ArgumentException)
			//	{
			//		// If the conversion fails, display an error message and prompt the user to try again
			//		Console.WriteLine("reenter.");
			//	}
			//}

		}
		/////////Display//////////
		//cards on board
		//player input
		//number of cards remaining in NPC deck

		//display cards on board
		public static void CurrentCardsOnBoard(Board board)
		{
			Console.WriteLine("Current cards on board: ");
			foreach (Card card in board.CardsOnBoard())
				Console.WriteLine(card.Rank + " " + card.Suit);
		}

		public static bool GameOver(NPC computer, Board board)
		{
			//player win
			if (computer.GetCards.Count == 0 && board.Empty() == true)
				return true;
			//player lose
			else if (!board.HasValidCombination() && !board.Empty())
				return true;

			return false;
		}

	}
}