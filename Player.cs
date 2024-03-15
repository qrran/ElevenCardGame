using System;
namespace ElevenCardGame
{
	public class Player
	{   // has to be non-nullable since player has to select card
		private List<Card> selectedCards = new List<Card>();
		private string name;
		private int score;
		private int combinationSize = 3;
		private int totalRank;
		

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

		//2 cards can be selected in regular situation, 3 cards for JQK
		//--------------------------------

		//player select cards from the board
		public void SelectCards(Card card)
		{
			Card selectedCard = new Card(card.Rank, card.Suit);
			if (selectedCards.Count < combinationSize)
			{
				this.selectedCards.Add(selectedCard);
			}
			else if (selectedCards.Count > combinationSize)
				Console.WriteLine("Player have reach the limit of selection.");
		}

		public List<Card> GetSelectedCards()
		{
			return selectedCards;
		}
		private void CalculateRank(List<Card> SelectedCards)
		{
			foreach (Card selectedCard in SelectedCards)
			{
				totalRank += (int)selectedCard.Rank; // add the rank of each selected card
			}
		}
		// clear selected cards
		public void ClearSelectedCards()
		{
			selectedCards.Clear();
		}
	}
}

