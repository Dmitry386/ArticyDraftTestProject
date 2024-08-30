using Assets.Scripts.Systems.CmdSystem.Events;
using System;

namespace Assets.Scripts.Systems.CmdSystem.Receivers
{
    public interface ICommandReceiver
    {
        public event Action<CommandsReceiveEventArgs> OnCommandsReceived;
    }
}