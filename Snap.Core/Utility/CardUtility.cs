using Snap.Core.Model;

namespace Snap.Core.Utility
{
    public class CardUtility
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="card2"></param>
        /// <returns></returns>
        public static bool CheckCardForSnap(Card card1, Card card2, MathingConditions mathingCondition)
        {
            if (card1 == null || card2 == null) return false;
            switch (mathingCondition)
            {                
                case MathingConditions.FaceValue:
                    return card1.Rank == card2.Rank;
                case MathingConditions.SuitOfTheCard:
                    return card1.Suit == card2.Suit;
                case MathingConditions.Both:
                    return card1.Rank == card2.Rank && card1.Suit == card2.Suit;
                default:
                    return false;
            }            
        }

        /// <summary>
        /// Creates a colletion of cards based on user input
        /// </summary>
        /// <param name="noOfDecks"></param>
        /// <returns>Collection of cards </returns>
        public static IEnumerable<Card> CreateCardColletion(int noOfDecks)
        {
            string[] suits = { "♣", "♦", "♥", "♠" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            List<Card> cards = new List<Card>();

            for (int i = 0; i < noOfDecks; i++)
            {
                // Creates a deck of 52 unique cards
                foreach (var suit in suits)
                {
                    cards.AddRange(ranks.Select(rank => new Card(suit, rank)));
                }
            }
            return cards;
        }

        /// <summary>
        /// Suffles a collection of cards
        /// </summary>
        /// <param name="cards"></param>
        /// <returns>Suffled colletion of cards</returns>
        public static IEnumerable<Card> SuffleCards(IEnumerable<Card> cards)
        {
            Random rng = new();
            return cards.OrderBy(a => rng.Next());
        }
    }
}