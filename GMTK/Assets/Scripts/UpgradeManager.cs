using System.Linq;
using UnityEngine;
using Random = System.Random;

public class UpgradeManager : MonoBehaviour
{
    [SerializeField] private Health[] playerHealth;
    [SerializeField] private GameObject[] playerDamage;
    public HealthBooster[] healthBoost;
    public DamageBooster[] damageBoost;
    private int _stage;
    private readonly Random _random = new Random();

    private void Start()
    {
        healthBoost = healthBoost.OrderBy(x => _random.Next()).ToArray();
        damageBoost = damageBoost.OrderBy(x => _random.Next()).ToArray();
    }

    public void UpgradeHealth()
    {
        for (int i = 0; i < playerHealth.Length; i++)
        {
            if (playerHealth[i].gameObject.activeSelf)
            {
                playerHealth[i].healthSo.health += healthBoost[_stage].boost;
                //playerHealth[i].healthSo.health = playerHealth[i].healthSo.maxHealth;
                playerHealth[i].GetComponent<HealthUI>().UpdateUI();
            }
        }

        _stage++;
    }

    public void UpgradeAttack()
    {
        for (int i = 0; i < playerDamage.Length; i++)
        {
            if (playerDamage[i].gameObject.activeSelf)
            {
                playerDamage[i].GetComponent<DamageController>().damage.damageAmount += damageBoost[_stage].boost;
                playerDamage[i].GetComponent<DamageUI>().UpdateUI();
            }
        }

        _stage++;
    }
}