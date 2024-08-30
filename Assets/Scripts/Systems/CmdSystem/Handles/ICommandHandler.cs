using Assets.Scripts.Systems.CmdSystem.Data;
using Assets.Scripts.Systems.CmdSystem.Events;

namespace Assets.Scripts.Systems.CmdSystem.Handles
{
    public interface ICommandHandler
    {
        public void HandleCommand(CommandData cmd);
        public void HandleCommands(CommandsReceiveEventArgs cmds);
    }
}