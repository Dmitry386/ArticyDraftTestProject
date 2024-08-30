using Articy.Unity;
using Assets.Scripts.Systems.CmdSystem;
using Assets.Scripts.Systems.CmdSystem.Caches;
using Assets.Scripts.Systems.CmdSystem.Handles;
using Assets.Scripts.Systems.CmdSystem.Receivers;
using UnityEngine;

namespace Assets.Scripts.Core
{
    [DefaultExecutionOrder(-1)]
    internal class Bootstrap : MonoBehaviour
    {
        [SerializeField]
        private ArticyFlowPlayer _articyPlayer;

        private void Awake()
        {
            var cmdReceiver = new CommandReceiverArticy(_articyPlayer);
            var cmdCache = new CommandCache();
            var cmdHandler = new CommandHandler(cmdCache);
            var cmdSystem = new CommandSystem(cmdReceiver, cmdHandler);

            cmdReceiver.Init();
            cmdCache.Cache();
            cmdSystem.Init();
        }
    }
}