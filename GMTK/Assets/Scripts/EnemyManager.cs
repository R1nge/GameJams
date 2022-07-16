using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public List<Health> enemies;

    public void RemoveEnemy(Health health) => enemies.Remove(health);
}