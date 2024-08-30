using Assets.Scripts.Systems.CmdSystem.Data;
using System;
using System.Linq;
using System.Reflection;

namespace Assets.Scripts.Systems.CmdSystem.Caches
{
    public class CommandCache : ICommandCache
    {
        private CachedCommandData[] _cachedCommands = new CachedCommandData[0];

        public void Cache()
        {
            CacheCommands();
        }

        private void CacheCommands()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var methods = GetMethodsWithAttribute<CmdAttribute>(assembly);
            _cachedCommands = new CachedCommandData[methods.Length];

            for (int i = 0; i < methods.Length; i++)
            {
                string cmdName = methods[i].GetCustomAttribute<CmdAttribute>().Command;
                if (string.IsNullOrEmpty(cmdName)) cmdName = methods[i].Name;

                _cachedCommands[i] = new CachedCommandData()
                {
                    Name = cmdName.ToLower(),
                    UseMethod = methods[i]
                };
            }
        }

        public static MethodInfo[] GetMethodsWithAttribute<T>(Assembly assembly) where T : Attribute
        {
            return assembly.GetTypes()
                   .SelectMany(t => t.GetMethods())
                   .Where(m => m.GetCustomAttributes<T>(false).Count() > 0)
                   .ToArray();
        }

        public CachedCommandData[] GetCommands()
        {
            return _cachedCommands.ToArray();
        }

        public CachedCommandData GetCommand(string command)
        {
            return _cachedCommands.FirstOrDefault(x => x.Name.ToLower() == command.ToLower());
        }
    }
}