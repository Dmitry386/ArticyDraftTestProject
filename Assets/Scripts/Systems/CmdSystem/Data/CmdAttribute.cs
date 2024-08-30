using System;

namespace Assets.Scripts.Systems.CmdSystem.Data
{
    public class CmdAttribute : Attribute
    {
        public string Command = string.Empty;

        public CmdAttribute(string command)
        {
            Command = command;
        }

        public CmdAttribute()
        {
        }
    }
}