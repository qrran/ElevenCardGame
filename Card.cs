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
		public Card(Rank rank, Suit suit)
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
		//convert string to Card
		public static Card Parse(string cardString)
		{
			// split the string by space to separate rank and suit
			string[] parts = cardString.Split(' ');

			if (!Enum.TryParse(parts[0], out Rank rank))
			{
				throw new ArgumentException("Invalid card rank.");
			}

			if (!Enum.TryParse(parts[1], out Suit suit))
			{
				throw new ArgumentException("Invalid card suit.");
			}

			// create and return a new Card objectT
			return new Card(rank, suit);
		}

	}

}