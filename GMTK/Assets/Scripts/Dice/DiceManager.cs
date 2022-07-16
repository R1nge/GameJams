using System;
using System.Collections;
using UnityEngine;

namespace Dice
{
    public class DiceManager : MonoBehaviour
    {
        public bool isAuto;
        public static event Action ONDICEROLL;
        [SerializeField] private float delay = .5f;
        [SerializeField] private DiceUI[] diceUI;
        [SerializeField] private DiceSo[] dices;
        private int _diceIndex;

        private void Start() => StartCoroutine(RollDice_c());

        private IEnumerator RollDice_c()
        {
            while (enabled)
            {
                yield return new WaitForSeconds(delay);
                if (isAuto)
                {
                    RollDice();
                }
            }
        }

        public void ManualRoll()
        {
            if (isAuto) return;
            RollDice();
        }

        private void RollDice()
        {
            if (Time.timeScale == 0) return;
            for (var i = 0; i < diceUI.Length; i++)
            {
                diceUI[i].UpdateUI(dices[i].RollDice());
            }

            ONDICEROLL?.Invoke();
        }
    }
}