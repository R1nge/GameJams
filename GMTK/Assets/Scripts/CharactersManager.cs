using UnityEngine;

public class CharactersManager : MonoBehaviour
{
    [SerializeField] private GameObject[] characters;

    private void Start() => Spawn();

    public void Spawn()
    {
        foreach (var character in characters)
        {
            character.SetActive(false);
        }

        characters[Random.Range(0, characters.Length)].SetActive(true);
    }
}