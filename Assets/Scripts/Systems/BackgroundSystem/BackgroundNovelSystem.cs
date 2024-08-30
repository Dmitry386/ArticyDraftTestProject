using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Systems.BackgroundSystem
{
    public class BackgroundNovelSystem : MonoBehaviour
    {
        [SerializeField]
        private Image _img;

        public void SetBackground(Sprite img)
        {
            _img.sprite = img;
        }
    }
}