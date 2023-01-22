using NSubstitute;
using NUnit.Framework;
using Snap.Core.Factories;
using Snap.Core.Interfaces;
using Snap.Core.Model;

namespace Snap.Test
{
    [TestFixture]
    public class GameManagerTest
    {
        private IGameManager _gameManager;
        private ISnapUI _ui; 


        [SetUp]
        public void Setup()
        {
            _ui = Substitute.For<ISnapUI>();
            _gameManager = GameManagerFactory.Instance.CreateSnapGameManager(_ui);
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void CommonPile_Count_MatchesSelectedOption(int noOfDeks)
        {
            //Arrange
            var selectedOption = new InputData() { MatchingCondition = MathingConditions.FaceValue, NoOfDecks = noOfDeks };

            //Act
            _gameManager.Init(selectedOption);

            //Assert
            Assert.That(_gameManager.CommonPile.Count(), Is.EqualTo(selectedOption.NoOfDecks * 52));
        }


        [Test]
        public void CurrentRun_Count_MatchesNoOfDeals()
        {
            //Arrange
            var selectedOption = new InputData() { MatchingCondition = MathingConditions.FaceValue, NoOfDecks = 2 };

            var currentRun = 0;
            var snap = false;
            var dealCount = 0;
            _ui.DisplayMessageBox(Arg.Do<string>(s =>
            {
                if (s == "It's a Snap !!!")
                {
                    snap = true;
                    currentRun = _gameManager.CurrentRun.Count();
                }
            }));

            //Act
            _gameManager.Init(selectedOption);
            _gameManager.Suffle();

            for (int i = 0; i < selectedOption.NoOfDecks * 52; i++)
            {
                if (snap)
                {
                    dealCount = i;
                    break;
                }
                _gameManager.Deal();
            }

            //Assert
            Assert.That(_gameManager.CommonPile.Count(), Is.EqualTo(selectedOption.NoOfDecks * 52 - dealCount));
            Assert.That(currentRun, Is.EqualTo(dealCount));
        }

        [Test]
        public void AssignToPlayer_Count_MatchesNoCurrentRunCards()
        {
            //Arrange
            var selectedOption = new InputData() { MatchingCondition = MathingConditions.FaceValue, NoOfDecks = 3 };

            var currentRun = 0;
            var snap = false;
            var dealCount = 0;
            _ui.DisplayMessageBox(Arg.Do<string>(s =>
            {
                if (s == "It's a Snap !!!")
                {
                    snap = true;
                    currentRun = _gameManager.CurrentRun.Count();
                }
            }));

            //Act
            _gameManager.Init(selectedOption);
            _gameManager.Suffle();

            for (int i = 0; i < selectedOption.NoOfDecks * 52; i++)
            {
                if (snap)
                {
                    dealCount = i;
                    break;
                }
                _gameManager.Deal();
            }

            //Assert
            Assert.That(_gameManager.CommonPile.Count(), Is.EqualTo(selectedOption.NoOfDecks * 52 - dealCount));
            Assert.That(currentRun, Is.EqualTo(dealCount));
            Assert.That(currentRun, Is.AnyOf(_gameManager.Player1Cards.Count(), _gameManager.Player2Cards.Count()));
        }
    }
}