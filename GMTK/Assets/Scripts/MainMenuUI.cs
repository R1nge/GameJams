using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private GameObject playButton, levelScreen;
    [SerializeField] private Button[] levels;

    private void Start()
    {
        for (int i = 0; i < levels.Length; i++)
        {
            levels[i].interactable = false;
        }

        var index = PlayerPrefs.GetInt("UnlockedLevel");

        for (int i = 0; i <= index; i++)
        {
            levels[i].interactable = true;
        }
    }

    public void Play()
    {
        playButton.SetActive(false);
        levelScreen.SetActive(true);
    }

    public void ChangeScene(string sceneName) => SceneManager.LoadScene(sceneName);
}