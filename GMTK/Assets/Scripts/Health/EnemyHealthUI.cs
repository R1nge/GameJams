using UnityEngine;

public class EnemyHealthUI : MonoBehaviour
{
    [SerializeField] private HealthSo healthSo;
    [SerializeField] private SpriteRenderer spriteRenderer;

    private void Start() => UpdateUI();

    public void UpdateUI() => spriteRenderer.size = new Vector2(healthSo.health * .32f, .32f);
}