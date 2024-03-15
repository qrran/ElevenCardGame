using System;

namespace ElevenCardGame
{
	public class Program
	{
		//set up
		static NPC computer = new NPC();
		static Player player = new Player("Dan");
		static Board board = new Board();

		public static void Main()
		{
			WelcomeMessage();

			computer.Shuffle();
			//1. initialize board with 9 cards from computer
			BoardInitialize();
			//display cards on board
			CurrentCardsOnBoard(board);
			//2. player action
			while (!GameOver(computer, board))
			{
				//player select card from the board
				//rank is recorded along with player input
				//CombinationSize includes regular case 2 and JQK case 3
				//PlayerInput();
				for (int i = 0; i < 2; i++)
				{
					PlayerInput();
				}
				if (player.FoundJQK(player.GetSelectedCards()))
					PlayerInput();

				//computer check for validation
				//if valid, remove cards from board && reset rank
				RemoveValidCombination();
				//display board
				CurrentCardsOnBoard(board);
			}

		}
		//welcome message
		public static void WelcomeMessage()
		{
			Console.WriteLine("Welcome to Eleven Card Game!");
			Console.WriteLine("-----------Rule-------------");
			Console.WriteLine("Select cards from the board");
			Console.WriteLine("You can't select two same cards");
			Console.WriteLine("*******************************************************");
			Console.WriteLine("**Please type exact card name as it appeared on board**");
			Console.WriteLine("*******************************************************\n");
		}

		//initialize cards on board, computer distribute cards to the board
		public static void BoardInitialize()
		{
			while (!board.Full() && board.CardsOnBoard().Count < 9)
			{
				board.AddCards(computer.TakeTopCard());
			}
		}

		//Player select card && record current rank
		public static void PlayerInput()
		{
			Console.WriteLine("\nPick a card: ");
			string input = Console.ReadLine();
			Card selectedCard = Card.Parse(input);
			Console.WriteLine($"You have selected: {selectedCard.Rank} {selectedCard.Suit}");
			player.SelectCards(selectedCard);
			Console.WriteLine("Card selected successfully.");
			player.CalculateRank(selectedCard);
			Console.WriteLine("Your current rank is: " + player.GetCurrentRank());
		}

		//computer check for validation
		//if valid, remove cards from board, reset rank selected
		public static void RemoveValidCombination()
		{
			if (computer.IsValid(player.GetSelectedCards()))
			{
				board.RemoveCards(player.GetSelectedCards());
				Console.WriteLine("Valid combination! Cards have been removed.");
				//only add card to the board after removed valid card combination
				BoardInitialize();
				//clear calculated total rank from cards selected previously
				player.ClearSelectedCards_Rank();
			}
			else
			{
				Console.WriteLine("Invalid combination. Please select again.");
				player.ClearSelectedCards_Rank();
			}
		}
		//display cards on board
		public static void CurrentCardsOnBoard(Board board)
		{
			Console.WriteLine("\n------------------------");
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
			//can add 1 more, player submission limit
			return false;
		}

	}
}