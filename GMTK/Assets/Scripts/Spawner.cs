using UnityEngine;
using Random = System.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private int currentStage;
    private readonly Random _random = new Random();

    private void Start()
    {
        //enemies = enemies.OrderBy(x => _random.Next()).ToArray();
        Spawn();
    }

    public void Spawn()
    {
        enemies[currentStage].SetActive(true);
        if (currentStage >= enemies.Length - 1) return;
        currentStage++;
    }
}