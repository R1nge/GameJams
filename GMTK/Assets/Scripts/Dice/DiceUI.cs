using UnityEngine;

namespace Dice
{
    public class DiceUI : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer[] diceFaces;
        
        public void UpdateUI(int index)
        {
            foreach (var face in diceFaces)
            {
                face.enabled = false;
            }

            diceFaces[index].enabled = true;
        }
    }
}