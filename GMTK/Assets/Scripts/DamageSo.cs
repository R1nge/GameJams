using UnityEngine;

[CreateAssetMenu(fileName = "Damage", menuName = "SO/Damage")]
public class DamageSo : ScriptableObject
{
    public int originalDamageAmount;
    public int damageAmount;

    public void ResetDamage() => damageAmount = originalDamageAmount;
}