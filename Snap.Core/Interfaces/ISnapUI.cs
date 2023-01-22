namespace Snap.Core.Interfaces
{
    public interface ISnapUI
    {
        void DisplayMessageBox(string message);

        int CommonCount { get; set; }

        int Player1Count { get; set; }

        int Player2Count { get; set; }

        int CurrentRun { get; set; }

        string CurrentCard { set; }

        string PreviousCard { set; }
    }
}