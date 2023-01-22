using Snap.Core.Model;

namespace Snap.Core.Interfaces
{
    public interface IGameManager
    {
        List<Card> CommonPile { get; }
        List<Card> CurrentRun { get; }
        List<Card> Player1Cards { get; }
        List<Card> Player2Cards { get; }

        void Deal();
        void Init(InputData selectedOption);
        void Suffle();
    }
}