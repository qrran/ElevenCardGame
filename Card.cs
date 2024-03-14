using System;

namespace ElevenCardGame
{

	public class Card
	{
		Suit suit;
		Rank rank;
		bool faceUp;


		// Properties
		public Suit Suit { get { return suit; } }

		public Rank Rank { get { return rank; } }

		public bool FaceUp { get { return faceUp; } }

		// Constructor
		public Card(Suit suit, Rank rank)
		{
			this.suit = suit;
			this.rank = rank;
			faceUp = false;
		}
		// Method
		public void FlipOver()
		{
			faceUp = true;
		}

	}

}