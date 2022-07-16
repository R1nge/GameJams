using System;
using TMPro;
using UnityEngine;

public class UpgradeUI : MonoBehaviour
{
    [SerializeField] private GameObject health, damage;
    [SerializeField] private TextMeshProUGUI healthText, damageText;
    private UpgradeManager _upgradeManager;
    private int _stage;

    private void Awake() => _upgradeManager = GetComponent<UpgradeManager>();

    public void Show()
    {
        Time.timeScale = 0;
        healthText.text = _upgradeManager.healthBoost[_stage].boost.ToString();
        damageText.text = _upgradeManager.damageBoost[_stage].boost.ToString();
        health.SetActive(true);
        damage.SetActive(true);
        _stage++;
    }

    public void Hide()
    {
        Time.timeScale = 1;
        health.SetActive(false);
        damage.SetActive(false);
    }
}