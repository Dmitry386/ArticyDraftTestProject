using Assets.Scripts.Systems.CmdSystem.Events;
using Assets.Scripts.Systems.CmdSystem.Handles;
using Assets.Scripts.Systems.CmdSystem.Receivers;
using System;

namespace Assets.Scripts.Systems.CmdSystem
{
    internal class CommandSystem : IDisposable
    {
        private ICommandReceiver _commandReceiver;
        private ICommandHandler _commandHandler;

        public CommandSystem(ICommandReceiver commandReceiver, ICommandHandler commandHandler)
        {
            _commandReceiver = commandReceiver;
            _commandHandler = commandHandler;
        }

        public void Init()
        {
            _commandReceiver.OnCommandsReceived += OnCommandsReceived;
        }

        private void OnCommandsReceived(CommandsReceiveEventArgs cmds)
        {
            _commandHandler.HandleCommands(cmds);
        }

        public void Dispose()
        {
            _commandReceiver.OnCommandsReceived -= OnCommandsReceived;
        }
    }
}