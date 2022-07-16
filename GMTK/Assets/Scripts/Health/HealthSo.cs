using UnityEngine;

[CreateAssetMenu(fileName = "HealthSo", menuName = "SO/Health")]
public class HealthSo : ScriptableObject
{
    public int originalHealth;
    public int health, maxHealth;

    private void OnEnable() => ResetHealth();

    public void ResetHealth()
    {
        maxHealth = originalHealth;
        health = maxHealth;
    }
}