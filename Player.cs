using System;
namespace ElevenCardGame
{
	public class Player
	{   // has to be non-nullable since player has to select card
		private List<Card> selectedCards = new List<Card>();
		private string name;
		private int score;
		private int totalRank = 0;
		private bool foundJQK;


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
				selectedCards.Add(card);
		}
		// if player selected JQK
		public bool FoundJQK(List<Card> cards)
		{
			foundJQK = false;// JQK card not found
			// check if any of the selected cards are J, Q, or K
			foreach (Card card in cards)
			{
				if (card.Rank == Rank.Jack || card.Rank == Rank.Queen || card.Rank == Rank.King)
				{
					foundJQK = true; // JQK card found
				}
			}
			return foundJQK;
		}
		
		public List<Card> GetSelectedCards()
		{
			return selectedCards;
		}
		// clear selected cards
		public void ClearSelectedCards_Rank()
		{
			selectedCards.Clear();
			totalRank = 0;
		}
		
		public void CalculateRank(Card selectedCard)
		{
			totalRank += (int)selectedCard.Rank;
		}
		public int GetCurrentRank()
		{
			return totalRank;
		}
	}
}

