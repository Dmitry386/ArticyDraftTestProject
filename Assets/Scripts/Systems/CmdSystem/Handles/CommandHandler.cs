using Assets.Scripts.Systems.CmdSystem.Caches;
using Assets.Scripts.Systems.CmdSystem.Data;
using Assets.Scripts.Systems.CmdSystem.Events;
using UnityEngine;

namespace Assets.Scripts.Systems.CmdSystem.Handles
{
    public class CommandHandler : ICommandHandler
    {
        private ICommandCache _commandCache;

        public CommandHandler(ICommandCache commandCache)
        {
            _commandCache = commandCache;
        }

        public void HandleCommands(CommandsReceiveEventArgs cmds)
        {
            foreach (var cmd in cmds.Commands)
            {
                HandleCommand(cmd);
            }
        }

        public void HandleCommand(CommandData cmd)
        {
            if (cmd == null) return;

            var cachedCmd = _commandCache.GetCommand(cmd.Command);

            if (cachedCmd != null)
            {
                if (cachedCmd.UseMethod != null)
                {
                    Debug.Log($"Execution cmd ({cmd.Command}: {string.Join(',', cmd.Arguments)})");
                    cachedCmd.UseMethod.Invoke(null, cmd.Arguments); 
                }
            }
            else
            {
                Debug.LogWarning($"{cmd.Command} not found");
            }
        }
    }
}