using Dice;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageController : MonoBehaviour
{
    public DamageSo damage;
    [SerializeField] private DiceSo playerDice;
    [SerializeField] private DiceSo enemyDice;
    private EnemyManager _target;

    private void Awake()
    {
        DiceManager.ONDICEROLL += DoDamage;
        _target = FindObjectOfType<EnemyManager>();
        damage.ResetDamage();
    }

    private void DoDamage()
    {
        for (var i = 0; i < _target.enemies.Count; i++)
        {
            if (_target.enemies.Count <= 0)
            {
                //TODO:    WIN
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                return;
            }

            if (playerDice.number > enemyDice.number)
            {
                if (_target.enemies[i].gameObject.activeSelf)
                {
                    _target.enemies[i].TakeDamage(damage.damageAmount);
                }
            }
        }
    }

    private void OnDisable() => DiceManager.ONDICEROLL -= DoDamage;
}