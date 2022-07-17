using UnityEngine;

public class UnlockLevel : MonoBehaviour
{
    public void Unlock(int index)
    {
        PlayerPrefs.SetInt("UnlockedLevel", index);
        PlayerPrefs.Save();
    }
}