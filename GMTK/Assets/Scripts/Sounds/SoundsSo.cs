using UnityEngine;

[CreateAssetMenu(fileName = "Sounds", menuName = "SO/Sounds", order = 0)]
public class SoundsSo : ScriptableObject
{
    public AudioClip spawnSound;
    public AudioClip[] hitSounds;
    public AudioClip dieSounds;
    public AudioClip music;
}