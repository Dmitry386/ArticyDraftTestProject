using Articy.Dracula_articyXBasics;
using Articy.Unity;
using Assets.Scripts.Systems.CmdSystem.Data;
using Assets.Scripts.Systems.CmdSystem.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Systems.CmdSystem.Receivers
{
    public class CommandReceiverArticy : ICommandReceiver, IDisposable
    {
        private ArticyFlowPlayer _observePlayer;

        public event Action<CommandsReceiveEventArgs> OnCommandsReceived;

        public CommandReceiverArticy(ArticyFlowPlayer observePlayer)
        {
            _observePlayer = observePlayer;
        }

        public void Init()
        {
            _observePlayer.onBranchesUpdated = OnUpdated;
        }

        private void OnUpdated(IList<Branch> aBranches)
        {
            var cmds = GetCommands(aBranches);
            OnCommandsReceived?.Invoke(cmds);
        }

        private CommandsReceiveEventArgs GetCommands(IList<Branch> aBranches)
        {
            var res = new CommandsReceiveEventArgs();

            foreach (var branch in aBranches)
            {
                foreach (var path in branch.Path)
                {
                    if (path is DialogueLine dialLine)
                    {
                        res.Commands = GetCommandAndArgs(dialLine.StageDirections.Value);
                        return res;
                    }
                }
            }

            return res;
        }

        private CommandData[] GetCommandAndArgs(string line)
        {
            var cmdsSplit = line.Split(';').Where(x => !string.IsNullOrEmpty(x)).ToArray();
            var res = new CommandData[cmdsSplit.Length];

            if (res.Length == 0)
            {
                Debug.Log("No commands to read");
                return res;
            }

            Debug.Log($"Commands reading... ");
            for (int i = 0; i < res.Length; i++)
            {
                var c = cmdsSplit[i];
                var cmdArgSplit = c.Split(": ");

                if (cmdArgSplit.Length != 2)
                {
                    Debug.LogError($"Fail to read command line: [{line}]");
                    Debug.LogError($"{c} - incorrect command line");

                    break;
                }
                else
                {
                    string cmd = cmdArgSplit[0].ToLower();
                    string[] args = new string[] { cmdArgSplit[1].Replace("\"", string.Empty) }; // todo: read multiple args rules

                    res[i] = new CommandData()
                    {
                        Command = cmd,
                        Arguments = args
                    };

                    Debug.Log($"Readed command: ({cmd}: {string.Join(',', args)})");
                }
            }

            return res;
        }

        public void Dispose()
        {
            OnCommandsReceived = null;
        }
    }
}