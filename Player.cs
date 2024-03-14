using System;
namespace ElevenCardGame
{
	public class Player
	{
		private List<Card> selectedCards = new List<Card>(); // has to be non-nullable
		private int score;
		private int selectedCardNum = 2;
		private int totalRank = 0;

		public Player()
		{
			score = 0;
		}
		//if valid, score ++
		public int Score()
		{
			return score;
		}

		//player input format needs to be reconsidered, how to select a card?
		public List<Card> SelectCards(Card card)
		{
			if (selectedCards.Count == 0)
				Console.WriteLine("Player didn't selected any card.");
			if (selectedCards.Count < selectedCardNum)
			{
				Card selectedCard = new Card(card.Suit, card.Rank);
				selectedCards.Add(selectedCard);
				CalculateRank();
			}
			else if (selectedCards.Count > selectedCardNum)
				Console.WriteLine("Player have reach the limit of selection.");
			return selectedCards;
		}

		private void CalculateRank()
		{
			foreach (Card selectedCard in selectedCards)
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

