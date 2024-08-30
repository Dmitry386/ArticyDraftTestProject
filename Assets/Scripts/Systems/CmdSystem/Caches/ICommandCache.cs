using Assets.Scripts.Systems.CmdSystem.Data;

namespace Assets.Scripts.Systems.CmdSystem.Caches
{
    public interface ICommandCache
    {
        public void Cache();
        public CachedCommandData GetCommand(string command);
        public CachedCommandData[] GetCommands();
    }
}