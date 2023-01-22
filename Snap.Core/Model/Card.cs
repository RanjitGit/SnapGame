namespace Snap.Core.Model
{
    public class Card
    {
        /// <summary>
        /// Rank of the Card like 2,3 etc
        /// </summary>
        public string Rank { get; set; }

        /// <summary>
        /// Suit of the Card like Ace, Diamond etc
        /// </summary>
        public string Suit { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="suit"></param>
        /// <param name="rank"></param>
        public Card(string suit, string rank)
        {
            Suit = string.IsNullOrEmpty(suit) ? throw new Exception(string.Format("Suit can't be empty")) : suit;
            Rank = string.IsNullOrEmpty(rank) ? throw new Exception(string.Format("Rank can't be empty")) : rank;
        }

        /// <summary>
        /// Makes it easy to print the card values
        /// </summary>
        /// <returns></returns>
        public string CardValueAsString()
        {
            return $"{Rank}{Suit}";
        }
    }

}
