using Microsoft.Extensions.Logging;
using Snap.Core.Interfaces;
using Snap.Core.Managers;

namespace Snap.Core.Factories
{
    public sealed class GameManagerFactory : IGameManagerFactory
    {
        private static readonly Lazy<IGameManagerFactory> _instance = new Lazy<IGameManagerFactory>(() => new GameManagerFactory());

        private GameManagerFactory() { }

        public static IGameManagerFactory Instance { get => _instance.Value; }

        public IGameManager CreateSnapGameManager(ISnapUI snapUI, ILogger logger)
        {
            return new SnapGameManager(snapUI, logger);
        }
    }
}
