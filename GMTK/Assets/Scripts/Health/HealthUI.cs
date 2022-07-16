using TMPro;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    [SerializeField] private HealthSo healthSo;
    [SerializeField] private TextMeshProUGUI text;

    private void Start() => UpdateUI();

    public void UpdateUI() => text.text = healthSo.health.ToString();
}