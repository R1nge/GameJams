using UnityEngine;
using UnityEngine.UI;

namespace Dice
{
    public class DiceModeUI : MonoBehaviour
    {
        [SerializeField] private DiceManager diceManager;
        [SerializeField] private Toggle auto;

        private void Start() => UpdateMode();

        public void UpdateMode() => diceManager.isAuto = auto.isOn;
    }
}