using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public void WinGame(string sceneName) => SceneManager.LoadScene(sceneName);
}