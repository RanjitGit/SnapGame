using Microsoft.Extensions.Logging;

namespace Snap.Core.Interfaces
{
    public interface IGameManagerFactory
    {
        IGameManager CreateSnapGameManager(ISnapUI snapUI, ILogger logger);
    }
}