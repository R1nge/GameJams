using UnityEngine;

namespace Dice
{
    [CreateAssetMenu(fileName = "Dice", menuName = "SO/Dice")]
    public class DiceSo : ScriptableObject
    {
        public int number;

        public int RollDice() => number = Random.Range(0, 5);
    }
}