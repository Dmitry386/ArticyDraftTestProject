using Assets.Scripts.Systems.BackgroundSystem;
using Assets.Scripts.Systems.CmdSystem.Data;
using Assets.Scripts.Systems.EmotionSystem;
using System.Linq;
using UnityEngine;

namespace Assets.Scripts.Systems.CmdSystem.Commands
{
    // todo: требуется оптимизация, писалось на скорую руку
    public static class VisualCommands
    {
        [Cmd("background")]
        public static void SetBackground(string backgroundName)
        {
            var background = Resources.LoadAll<Sprite>(string.Empty).FirstOrDefault(x => x.name == backgroundName);

            if (background)
            {
                GameObject.FindFirstObjectByType<BackgroundNovelSystem>()?.SetBackground(background);
            }
            else
            {
                Debug.LogWarning($"No background with name: {backgroundName}");
            }
        }

        [Cmd("emotion")]
        public static void SetEmotion(string emotion)
        {
            if (emotion == "angry")
            {
                GameObject.FindFirstObjectByType<EmotionCharacterSystem>()?.SetAngry(true);
            }
        }
    }
}