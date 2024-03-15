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
				PlayerInput();
				//player selects second card
				PlayerInput();
				//check if JQK selected
				//2 cards regular case, 3 cards for JQK
				//if selected any of JQK, input one more time
				if (foundJQK(player.GetSelectedCards()))
				{
					PlayerInput();
				}
				//----a problem here: CalculateRank() can't get third input if foundJQK-----
				//calculate rank
				Console.WriteLine("Your rank is: " + player.CalculateRank(player.GetSelectedCards()));
				//computer check for validation, if valid remove cards from board
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

		//Player select card now
		public static void PlayerInput()
		{
			Console.WriteLine("\nPick a card: ");
			string input = Console.ReadLine();
			Card selectedCard = Card.Parse(input);
			Console.WriteLine($"You have selected: {selectedCard.Rank} {selectedCard.Suit}");
			player.SelectCards(selectedCard);
			Console.WriteLine("Card selected successfully.");
		}
		public static bool foundJQK(List<Card> cards)
		{
			// check if any of the selected cards are J, Q, or K
			foreach (Card card in cards)
			{
				if (card.Rank == Rank.Jack || card.Rank == Rank.Queen || card.Rank == Rank.King)
				{
					return true; // JQK card found
				}
			}
			return false; // JQK card not found
		}

		//computer check for validation, if valid, remove cards from board
		public static void RemoveValidCombination()
		{
			if (computer.IsValid(player.GetSelectedCards()))
			{
				board.RemoveCards(player.GetSelectedCards());
				Console.WriteLine("Valid combination! Cards have been removed.");
				//only add card to the board after removed valid card combination
				BoardInitialize();
			}
			else
			{
				Console.WriteLine("Invalid combination. Please select again.");
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

			return false;
		}

	}
}