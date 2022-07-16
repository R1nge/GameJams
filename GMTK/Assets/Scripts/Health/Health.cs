using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour, IDamageable
{
    public HealthSo healthSo;
    public UnityEvent onDamageEvent;
    public UnityEvent onDieEvent;

    private void Awake() => healthSo.ResetHealth();

    public void TakeDamage(int amount)
    {
        healthSo.health -= amount;
        onDamageEvent?.Invoke();

        if (healthSo.health <= 0)
        {
            onDieEvent?.Invoke();
        }
    }
}