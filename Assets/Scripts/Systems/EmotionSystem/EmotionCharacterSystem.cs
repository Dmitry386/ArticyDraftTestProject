using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Systems.EmotionSystem
{
    // todo: тестовая реализация только с angry эмоцией
    public class EmotionCharacterSystem : MonoBehaviour
    {
        [SerializeField]
        private Image _angrySprite;

        [SerializeField]
        [Min(0)]
        private float _angryTime = 10f;

        private void Awake()
        {
            SetAngry(false);
        }

        public void SetAngry(bool angry)
        {
            StartCoroutine(AngryWait(angry));
        }

        private IEnumerator AngryWait(bool angry)
        {
            _angrySprite.enabled = angry;
            yield return new WaitForSecondsRealtime(_angryTime);
            _angrySprite.enabled = false;
        }
    }
}