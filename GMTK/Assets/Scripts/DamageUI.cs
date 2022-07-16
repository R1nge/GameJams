using TMPro;
using UnityEngine;

public class DamageUI : MonoBehaviour
{
    [SerializeField] private DamageSo damageSo;
    [SerializeField] private TextMeshProUGUI text;

    private void Start() => UpdateUI();

    public void UpdateUI() => text.text = damageSo.damageAmount.ToString();
}