using UnityEngine;

namespace Sounds
{
    public class EntitySound : MonoBehaviour
    {
        [SerializeField] private SoundsSo soundsSo;
        [SerializeField] private AudioSource audioSource;

        private void OnEnable()
        {
            audioSource.clip = soundsSo.spawnSound;
            audioSource.Play();
        }

        public void OnDamaged()
        {
            audioSource.clip = soundsSo.hitSounds[Random.Range(0, soundsSo.hitSounds.Length)];
            audioSource.Play();
        }
    }
}