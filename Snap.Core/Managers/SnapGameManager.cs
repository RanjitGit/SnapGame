using Microsoft.Extensions.Logging;
using Snap.Core.Interfaces;
using Snap.Core.Model;
using Snap.Core.Utility;

namespace Snap.Core.Managers
{
    public class SnapGameManager : IGameManager
    {
        private readonly ISnapUI _snapUI;
        private readonly ILogger _logger;
        private Card _currentCard;
        private Card _prevCard;
        private InputData _selectedOption;

        /// <summary>
        /// Contains the cards in common pile from whihc game will be played
        /// </summary>
        public List<Card> CommonPile { get; private set; } = new List<Card>();
        /// <summary>
        /// Contains the cards fetched from common pile in the current run till snap
        /// </summary>
        public List<Card> CurrentRun { get; private set; } = new List<Card>();
        /// <summary>
        /// Cards belonging to player 1
        /// </summary>
        public List<Card> Player1Cards { get; private set; } = new List<Card>();
        /// <summary>
        /// Cards belonging to Player 2
        /// </summary>
        public List<Card> Player2Cards { get; private set; } = new List<Card>();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="snapUI"></param>
        public SnapGameManager(ISnapUI snapUI, ILogger logger)
        {
            _snapUI = snapUI;
            _logger = logger;
        }

        /// <summary>
        /// Init method to start bilding the common pile from selected options
        /// </summary>
        /// <param name="selectedOption"></param>
        public void Init(InputData selectedOption)
        {
            _logger.LogInformation("Init Snap Manager");
            _selectedOption = selectedOption;
            CommonPile = CardUtility.CreateCardColletion(selectedOption.NoOfDecks).ToList();
            _snapUI.CommonCount = CommonPile.Count();
            _logger.LogInformation($"Common Pile count is {CommonPile.Count()}");
        }

        /// <summary>
        /// Start Dealing by picking up one card from common pile.
        /// </summary>
        public void Deal()
        {
            try
            {
                _logger.LogInformation("Starting Deal");
                if (CommonPile.Count() > 0)
                {
                    var seletedCard = CommonPile.First();
                    if (seletedCard != null)
                    {
                        if (_currentCard != null)
                        {
                            _prevCard = _currentCard;
                            _snapUI.PreviousCard = $"./Cards/{_prevCard.CardValueAsString()}.png";
                        }
                        _currentCard = seletedCard;
                        _snapUI.CurrentCard = $"./Cards/{_currentCard.CardValueAsString()}.png";
                        CommonPile.Remove(seletedCard);
                        _snapUI.CommonCount = CommonPile.Count();
                        CurrentRun.Add(seletedCard);
                        _snapUI.CurrentRun = CurrentRun.Count();

                        // Check for Snap
                        if (CardUtility.CheckCardForSnap(_currentCard, _prevCard, _selectedOption.MatchingCondition))
                        {
                            // It's Snap
                            _snapUI.DisplayMessageBox("It's a Snap !!!");
                            _logger.LogInformation("It's a Snap !!!");
                            // Select Random Player
                            var n = new Random().Next(3);

                            // Assgn the card to winner
                            if (n == 1)
                            {
                                Player1Cards.AddRange(CurrentRun);
                                _snapUI.Player1Count = Player1Cards.Count();
                            }
                            else
                            {
                                Player2Cards.AddRange(CurrentRun);
                                _snapUI.Player2Count = Player2Cards.Count();
                            }

                            CurrentRun.Clear();
                            _snapUI.CurrentRun = 0;

                            // Reset
                            _currentCard = null;
                            _prevCard = null;
                            _snapUI.CurrentCard = "";
                            _snapUI.PreviousCard = "";
                        }

                    }
                }
                else
                {
                    // Game Over, Declare the winner
                    var winMessage = Player1Cards.Count() > Player2Cards.Count() ? "Winner is Player 1" : "Winner is Player 2";
                    _snapUI.DisplayMessageBox(winMessage);
                    _logger.LogInformation(winMessage);
                }
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }

        /// <summary>
        /// Suffle the common pile 
        /// </summary>
        public void Suffle()
        {
            _snapUI.DisplayMessageBox("Suffling");
            CommonPile = CardUtility.SuffleCards(CommonPile).ToList();
        }        
    }
}
