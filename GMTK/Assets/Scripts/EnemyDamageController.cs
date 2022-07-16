using Dice;
using UnityEngine;

public class EnemyDamageController : MonoBehaviour
{
    [SerializeField] private Health[] targets;
    [SerializeField] private DamageSo damage;
    [SerializeField] private DiceSo playerDice;
    [SerializeField] private DiceSo enemyDice;

    private void Awake() => DiceManager.ONDICEROLL += DoDamage;

    private void DoDamage()
    {
        for (int i = 0; i < targets.Length; i++)
        {
            if (enemyDice.number > playerDice.number)
            {
                if (targets[i].gameObject.activeSelf)
                {
                    targets[i].TakeDamage(damage.damageAmount);
                }
            }
        }
    }

    private void OnDisable() => DiceManager.ONDICEROLL -= DoDamage;
}