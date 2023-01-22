namespace Snap.Core.Interfaces
{
    public interface IGameManagerFactory
    {
        IGameManager CreateSnapGameManager(ISnapUI snapUI);
    }
}