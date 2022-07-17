using TMPro;
using UnityEngine;

public class StagesUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private int stagesAmount;
    private int _index = 1;

    private void Start() => text.text = _index + " / " + stagesAmount;

    public void UpdateUI()
    {
        _index++;
        text.text = _index + " / " + stagesAmount;
    }
}