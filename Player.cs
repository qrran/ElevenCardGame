using System;
namespace ElevenCardGame
{
	public class Player
	{   // has to be non-nullable since player has to select card
		private List<Card> selectedCards = new List<Card>();
		private string name;
		private int score;
		//regular case: player select 2 cards to add up
		private int combinationSize = 2;
		private int totalRank = 0;
		

		public Player(string name)
		{
			this.name = name;
			score = 0;
		}

		public string Name
		{
			get { return name; }
		}
		//if valid, score ++
		public int Score
		{
			get { return score; }
		}

		//number of cards selected
		public int NumCardsSelected()
		{
			return selectedCards.Count;
		}

		//player select cards from the board
		public void SelectCards(Card card)
		{
			Card selectedCard = new Card(card.Rank, card.Suit);
			//regular case select 2 cards
			if (selectedCards.Count < combinationSize)
			{
				this.selectedCards.Add(selectedCard);
			}

			else if (selectedCards.Count > combinationSize)
				Console.WriteLine("Player has reach the limit of selection.");
		}

		public List<Card> GetSelectedCards()
		{
			return selectedCards;
		}
		public int CalculateRank(List<Card> SelectedCards)
		{
			foreach (Card selectedCard in SelectedCards)
			{
				totalRank += (int)selectedCard.Rank; // add the rank of each selected card
			}
			return totalRank;
		}
		// clear selected cards
		public void ClearSelectedCards()
		{
			selectedCards.Clear();
		}
	}
}

